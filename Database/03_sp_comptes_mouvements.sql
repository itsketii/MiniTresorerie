-- =====================================================================
--  PROCÉDURES STOCKÉES — Comptes de trésorerie et mouvements
-- =====================================================================
USE dbMiniTresorerie;
DELIMITER $$

-- ===== Fonction : solde courant d'un compte =====
DROP FUNCTION IF EXISTS FN_SoldeCompte$$
CREATE FUNCTION FN_SoldeCompte(p_compteId INT) RETURNS DECIMAL(15,2)
READS SQL DATA
BEGIN
  DECLARE v_solde DECIMAL(15,2);
  SELECT c.cptSoldeInitial + COALESCE(
           (SELECT SUM(CASE WHEN m.mvtType = 'RECETTE' THEN m.mvtMontant ELSE -m.mvtMontant END)
              FROM mouvement m WHERE m.compteId = c.compteId), 0)
    INTO v_solde
    FROM comptetresorerie c WHERE c.compteId = p_compteId;
  RETURN COALESCE(v_solde, 0);
END$$

-- ===== COMPTE DE TRESORERIE =====
DROP PROCEDURE IF EXISTS SP_Compte_Create$$
CREATE PROCEDURE SP_Compte_Create(IN p_code VARCHAR(15), IN p_libelle VARCHAR(100), IN p_typeCompteId INT,
                                  IN p_devise VARCHAR(10), IN p_soldeInitial DECIMAL(15,2), IN p_dateOuverture DATE,
                                  IN p_actif TINYINT, IN p_description VARCHAR(255), OUT p_id INT)
BEGIN
  INSERT INTO comptetresorerie(cptCode, cptLibelle, typeCompteId, cptDevise, cptSoldeInitial, cptDateOuverture, cptActif, cptDescription)
  VALUES (p_code, p_libelle, p_typeCompteId, p_devise, p_soldeInitial, p_dateOuverture, p_actif, p_description);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_Compte_ReadAll$$
CREATE PROCEDURE SP_Compte_ReadAll(IN p_filtre VARCHAR(200), IN p_actif TINYINT)
BEGIN
  SELECT c.compteId, c.cptCode, c.cptLibelle, c.typeCompteId, t.tcLibelle, c.cptDevise,
         c.cptSoldeInitial, c.cptDateOuverture, c.cptActif, c.cptDescription,
         FN_SoldeCompte(c.compteId) AS cptSolde
  FROM comptetresorerie c
  JOIN typecompte t ON t.typeCompteId = c.typeCompteId
  WHERE (p_filtre IS NULL OR p_filtre = '' OR c.cptCode LIKE CONCAT('%', p_filtre, '%')
         OR c.cptLibelle LIKE CONCAT('%', p_filtre, '%') OR t.tcLibelle LIKE CONCAT('%', p_filtre, '%'))
    AND (p_actif IS NULL OR c.cptActif = p_actif)
  ORDER BY c.cptCode;
END$$

DROP PROCEDURE IF EXISTS SP_Compte_ReadById$$
CREATE PROCEDURE SP_Compte_ReadById(IN p_id INT)
BEGIN
  SELECT c.compteId, c.cptCode, c.cptLibelle, c.typeCompteId, t.tcLibelle, c.cptDevise,
         c.cptSoldeInitial, c.cptDateOuverture, c.cptActif, c.cptDescription,
         FN_SoldeCompte(c.compteId) AS cptSolde
  FROM comptetresorerie c
  JOIN typecompte t ON t.typeCompteId = c.typeCompteId
  WHERE c.compteId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Compte_Update$$
CREATE PROCEDURE SP_Compte_Update(IN p_id INT, IN p_code VARCHAR(15), IN p_libelle VARCHAR(100), IN p_typeCompteId INT,
                                  IN p_devise VARCHAR(10), IN p_soldeInitial DECIMAL(15,2), IN p_dateOuverture DATE,
                                  IN p_actif TINYINT, IN p_description VARCHAR(255))
BEGIN
  UPDATE comptetresorerie
     SET cptCode = p_code, cptLibelle = p_libelle, typeCompteId = p_typeCompteId, cptDevise = p_devise,
         cptSoldeInitial = p_soldeInitial, cptDateOuverture = p_dateOuverture, cptActif = p_actif,
         cptDescription = p_description
   WHERE compteId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Compte_Delete$$
CREATE PROCEDURE SP_Compte_Delete(IN p_id INT)
BEGIN
  DELETE FROM comptetresorerie WHERE compteId = p_id;
END$$

-- ===== Vue détaillée des mouvements =====
CREATE OR REPLACE VIEW vw_mouvement_detail AS
SELECT m.mouvementId, m.mvtReference, m.mvtDate, m.mvtType, m.mvtLibelle, m.mvtMontant,
       m.compteId, c.cptCode, c.cptLibelle,
       m.categorieId, k.catLibelle,
       m.centreId, ci.ctrCode, ci.ctrLibelle,
       m.modePaiementId, mp.mpLibelle,
       m.mvtTiers, m.mvtPiece, m.mvtRapproche, m.mvtDateRapprochement,
       m.utilisateurId, u.usrLogin, m.mvtDateSaisie
FROM mouvement m
JOIN comptetresorerie c  ON c.compteId = m.compteId
JOIN categorie k         ON k.categorieId = m.categorieId
LEFT JOIN centreimputation ci ON ci.centreId = m.centreId
JOIN modepaiement mp     ON mp.modePaiementId = m.modePaiementId
JOIN utilisateur u       ON u.utilisateurId = m.utilisateurId$$

-- ===== MOUVEMENT =====
DROP PROCEDURE IF EXISTS SP_Mouvement_Create$$
CREATE PROCEDURE SP_Mouvement_Create(IN p_date DATE, IN p_type VARCHAR(10), IN p_libelle VARCHAR(150),
                                     IN p_montant DECIMAL(15,2), IN p_compteId INT, IN p_categorieId INT,
                                     IN p_centreId INT, IN p_modePaiementId INT, IN p_tiers VARCHAR(100),
                                     IN p_piece VARCHAR(60), IN p_utilisateurId INT, OUT p_id INT)
BEGIN
  DECLARE v_actif TINYINT(1);
  SELECT cptActif INTO v_actif FROM comptetresorerie WHERE compteId = p_compteId;
  IF v_actif IS NULL OR v_actif = 0 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Ce compte est cloture ou introuvable : operation impossible.';
  END IF;
  IF p_type = 'DEPENSE' AND FN_SoldeCompte(p_compteId) - p_montant < 0 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Solde insuffisant sur ce compte pour enregistrer cette depense.';
  END IF;

  INSERT INTO mouvement(mvtReference, mvtDate, mvtType, mvtLibelle, mvtMontant, compteId, categorieId,
                        centreId, modePaiementId, mvtTiers, mvtPiece, utilisateurId)
  VALUES (UUID(), p_date, p_type, p_libelle, p_montant, p_compteId, p_categorieId,
          p_centreId, p_modePaiementId, p_tiers, p_piece, p_utilisateurId);
  SET p_id = LAST_INSERT_ID();
  UPDATE mouvement
     SET mvtReference = CONCAT(IF(p_type = 'RECETTE', 'REC', 'DEP'), '-', DATE_FORMAT(p_date, '%Y%m'), '-', LPAD(p_id, 5, '0'))
   WHERE mouvementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Mouvement_ReadAll$$
CREATE PROCEDURE SP_Mouvement_ReadAll(IN p_filtre VARCHAR(200), IN p_debut DATE, IN p_fin DATE,
                                      IN p_compteId INT, IN p_centreId INT, IN p_type VARCHAR(10),
                                      IN p_rapproche TINYINT)
BEGIN
  SELECT * FROM vw_mouvement_detail v
  WHERE (p_filtre IS NULL OR p_filtre = '' OR v.mvtLibelle LIKE CONCAT('%', p_filtre, '%')
         OR v.mvtReference LIKE CONCAT('%', p_filtre, '%') OR v.mvtTiers LIKE CONCAT('%', p_filtre, '%')
         OR v.catLibelle LIKE CONCAT('%', p_filtre, '%') OR v.mvtPiece LIKE CONCAT('%', p_filtre, '%'))
    AND (p_debut IS NULL OR v.mvtDate >= p_debut)
    AND (p_fin IS NULL OR v.mvtDate <= p_fin)
    AND (p_compteId IS NULL OR v.compteId = p_compteId)
    AND (p_centreId IS NULL OR v.centreId = p_centreId)
    AND (p_type IS NULL OR p_type = '' OR v.mvtType = p_type)
    AND (p_rapproche IS NULL OR v.mvtRapproche = p_rapproche)
  ORDER BY v.mvtDate DESC, v.mouvementId DESC;
END$$

DROP PROCEDURE IF EXISTS SP_Mouvement_ReadById$$
CREATE PROCEDURE SP_Mouvement_ReadById(IN p_id INT)
BEGIN
  SELECT * FROM vw_mouvement_detail WHERE mouvementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Mouvement_Update$$
CREATE PROCEDURE SP_Mouvement_Update(IN p_id INT, IN p_date DATE, IN p_type VARCHAR(10), IN p_libelle VARCHAR(150),
                                     IN p_montant DECIMAL(15,2), IN p_compteId INT, IN p_categorieId INT,
                                     IN p_centreId INT, IN p_modePaiementId INT, IN p_tiers VARCHAR(100),
                                     IN p_piece VARCHAR(60))
BEGIN
  DECLARE v_rapproche TINYINT(1);
  DECLARE v_ancCompte INT;
  DECLARE v_ancType VARCHAR(10);
  DECLARE v_ancMontant DECIMAL(15,2);
  DECLARE v_solde DECIMAL(15,2);

  SELECT mvtRapproche, compteId, mvtType, mvtMontant
    INTO v_rapproche, v_ancCompte, v_ancType, v_ancMontant
    FROM mouvement WHERE mouvementId = p_id;

  IF v_rapproche IS NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Mouvement introuvable.';
  END IF;
  IF v_rapproche = 1 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Ce mouvement est deja pointe (rapproche) : depointez-le avant de le modifier.';
  END IF;

  IF p_type = 'DEPENSE' THEN
    SET v_solde = FN_SoldeCompte(p_compteId);
    IF v_ancCompte = p_compteId THEN
      SET v_solde = v_solde - IF(v_ancType = 'RECETTE', v_ancMontant, -v_ancMontant);
    END IF;
    IF v_solde - p_montant < 0 THEN
      SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Solde insuffisant sur ce compte pour cette depense.';
    END IF;
  END IF;

  UPDATE mouvement
     SET mvtDate = p_date, mvtType = p_type, mvtLibelle = p_libelle, mvtMontant = p_montant,
         compteId = p_compteId, categorieId = p_categorieId, centreId = p_centreId,
         modePaiementId = p_modePaiementId, mvtTiers = p_tiers, mvtPiece = p_piece
   WHERE mouvementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Mouvement_Delete$$
CREATE PROCEDURE SP_Mouvement_Delete(IN p_id INT)
BEGIN
  IF EXISTS (SELECT 1 FROM mouvement WHERE mouvementId = p_id AND mvtRapproche = 1) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Ce mouvement est deja pointe (rapproche) : suppression interdite.';
  END IF;
  DELETE FROM mouvement WHERE mouvementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Mouvement_Rapprocher$$
CREATE PROCEDURE SP_Mouvement_Rapprocher(IN p_id INT, IN p_etat TINYINT)
BEGIN
  UPDATE mouvement
     SET mvtRapproche = p_etat,
         mvtDateRapprochement = IF(p_etat = 1, NOW(), NULL)
   WHERE mouvementId = p_id;
END$$

DELIMITER ;
