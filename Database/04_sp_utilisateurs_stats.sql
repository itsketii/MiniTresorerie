-- =====================================================================
--  PROCÉDURES STOCKÉES — Utilisateurs (authentification) et statistiques
-- =====================================================================
USE dbMiniTresorerie;
DELIMITER $$

-- ===== UTILISATEUR =====
DROP PROCEDURE IF EXISTS SP_Utilisateur_Authentifier$$
CREATE PROCEDURE SP_Utilisateur_Authentifier(IN p_login VARCHAR(40), IN p_mdp VARCHAR(100))
BEGIN
  DECLARE v_id INT DEFAULT NULL;
  SELECT utilisateurId INTO v_id
    FROM utilisateur
   WHERE usrLogin = p_login AND usrActif = 1
     AND usrMotDePasse = SHA2(CONCAT(usrSel, p_mdp), 256)
   LIMIT 1;
  IF v_id IS NOT NULL THEN
    UPDATE utilisateur SET usrDerniereConnexion = NOW() WHERE utilisateurId = v_id;
  END IF;
  SELECT u.utilisateurId, u.usrNom, u.usrPrenom, u.usrLogin, u.roleId, r.roleLibelle,
         u.usrActif, u.usrDateCreation, u.usrDerniereConnexion
    FROM utilisateur u JOIN roleutilisateur r ON r.roleId = u.roleId
   WHERE u.utilisateurId = v_id;
END$$

DROP PROCEDURE IF EXISTS SP_Utilisateur_Create$$
CREATE PROCEDURE SP_Utilisateur_Create(IN p_nom VARCHAR(60), IN p_prenom VARCHAR(60), IN p_login VARCHAR(40),
                                       IN p_mdp VARCHAR(100), IN p_roleId INT, IN p_actif TINYINT, OUT p_id INT)
BEGIN
  DECLARE v_sel CHAR(36);
  SET v_sel = UUID();
  INSERT INTO utilisateur(usrNom, usrPrenom, usrLogin, usrSel, usrMotDePasse, roleId, usrActif)
  VALUES (p_nom, p_prenom, p_login, v_sel, SHA2(CONCAT(v_sel, p_mdp), 256), p_roleId, p_actif);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_Utilisateur_ReadAll$$
CREATE PROCEDURE SP_Utilisateur_ReadAll(IN p_filtre VARCHAR(200))
BEGIN
  SELECT u.utilisateurId, u.usrNom, u.usrPrenom, u.usrLogin, u.roleId, r.roleLibelle,
         u.usrActif, u.usrDateCreation, u.usrDerniereConnexion
    FROM utilisateur u JOIN roleutilisateur r ON r.roleId = u.roleId
   WHERE p_filtre IS NULL OR p_filtre = '' OR u.usrNom LIKE CONCAT('%', p_filtre, '%')
      OR u.usrPrenom LIKE CONCAT('%', p_filtre, '%') OR u.usrLogin LIKE CONCAT('%', p_filtre, '%')
      OR r.roleLibelle LIKE CONCAT('%', p_filtre, '%')
   ORDER BY u.usrNom, u.usrPrenom;
END$$

DROP PROCEDURE IF EXISTS SP_Utilisateur_ReadById$$
CREATE PROCEDURE SP_Utilisateur_ReadById(IN p_id INT)
BEGIN
  SELECT u.utilisateurId, u.usrNom, u.usrPrenom, u.usrLogin, u.roleId, r.roleLibelle,
         u.usrActif, u.usrDateCreation, u.usrDerniereConnexion
    FROM utilisateur u JOIN roleutilisateur r ON r.roleId = u.roleId
   WHERE u.utilisateurId = p_id;
END$$

-- p_mdp NULL ou vide => mot de passe inchangé
DROP PROCEDURE IF EXISTS SP_Utilisateur_Update$$
CREATE PROCEDURE SP_Utilisateur_Update(IN p_id INT, IN p_nom VARCHAR(60), IN p_prenom VARCHAR(60), IN p_login VARCHAR(40),
                                       IN p_mdp VARCHAR(100), IN p_roleId INT, IN p_actif TINYINT)
BEGIN
  DECLARE v_sel CHAR(36);
  DECLARE v_adminId INT;
  DECLARE v_estAdmin INT;
  DECLARE v_autres INT;

  SELECT roleId INTO v_adminId FROM roleutilisateur WHERE roleLibelle = 'Admin';
  SELECT COUNT(*) INTO v_estAdmin FROM utilisateur WHERE utilisateurId = p_id AND roleId = v_adminId AND usrActif = 1;
  SELECT COUNT(*) INTO v_autres FROM utilisateur WHERE utilisateurId <> p_id AND roleId = v_adminId AND usrActif = 1;
  IF v_estAdmin = 1 AND v_autres = 0 AND (p_roleId <> v_adminId OR p_actif = 0) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Operation refusee : il doit rester au moins un administrateur actif.';
  END IF;

  UPDATE utilisateur
     SET usrNom = p_nom, usrPrenom = p_prenom, usrLogin = p_login, roleId = p_roleId, usrActif = p_actif
   WHERE utilisateurId = p_id;

  IF p_mdp IS NOT NULL AND p_mdp <> '' THEN
    SET v_sel = UUID();
    UPDATE utilisateur SET usrSel = v_sel, usrMotDePasse = SHA2(CONCAT(v_sel, p_mdp), 256) WHERE utilisateurId = p_id;
  END IF;
END$$

DROP PROCEDURE IF EXISTS SP_Utilisateur_Delete$$
CREATE PROCEDURE SP_Utilisateur_Delete(IN p_id INT)
BEGIN
  DECLARE v_adminId INT;
  DECLARE v_estAdmin INT;
  DECLARE v_autres INT;
  SELECT roleId INTO v_adminId FROM roleutilisateur WHERE roleLibelle = 'Admin';
  SELECT COUNT(*) INTO v_estAdmin FROM utilisateur WHERE utilisateurId = p_id AND roleId = v_adminId AND usrActif = 1;
  SELECT COUNT(*) INTO v_autres FROM utilisateur WHERE utilisateurId <> p_id AND roleId = v_adminId AND usrActif = 1;
  IF v_estAdmin = 1 AND v_autres = 0 THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Suppression refusee : il doit rester au moins un administrateur actif.';
  END IF;
  DELETE FROM utilisateur WHERE utilisateurId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Utilisateur_ChangerMotDePasse$$
CREATE PROCEDURE SP_Utilisateur_ChangerMotDePasse(IN p_id INT, IN p_ancien VARCHAR(100), IN p_nouveau VARCHAR(100), OUT p_ok INT)
BEGIN
  DECLARE v_n INT;
  DECLARE v_sel CHAR(36);
  SELECT COUNT(*) INTO v_n FROM utilisateur
   WHERE utilisateurId = p_id AND usrMotDePasse = SHA2(CONCAT(usrSel, p_ancien), 256);
  IF v_n = 1 THEN
    SET v_sel = UUID();
    UPDATE utilisateur SET usrSel = v_sel, usrMotDePasse = SHA2(CONCAT(v_sel, p_nouveau), 256) WHERE utilisateurId = p_id;
    SET p_ok = 1;
  ELSE
    SET p_ok = 0;
  END IF;
END$$

-- ===== STATISTIQUES (tableau de bord et rapports) =====
DROP PROCEDURE IF EXISTS SP_Stats_Kpi$$
CREATE PROCEDURE SP_Stats_Kpi(IN p_debut DATE, IN p_fin DATE)
BEGIN
  SELECT
    COALESCE((SELECT SUM(FN_SoldeCompte(c.compteId)) FROM comptetresorerie c WHERE c.cptActif = 1), 0) AS tresorerieTotale,
    COALESCE((SELECT SUM(m.mvtMontant) FROM mouvement m WHERE m.mvtType = 'RECETTE' AND m.mvtDate BETWEEN p_debut AND p_fin), 0) AS totalRecettes,
    COALESCE((SELECT SUM(m.mvtMontant) FROM mouvement m WHERE m.mvtType = 'DEPENSE' AND m.mvtDate BETWEEN p_debut AND p_fin), 0) AS totalDepenses,
    (SELECT COUNT(*) FROM mouvement m WHERE m.mvtDate BETWEEN p_debut AND p_fin) AS nbMouvements,
    (SELECT COUNT(*) FROM mouvement m WHERE m.mvtRapproche = 0) AS nbNonRapproches,
    (SELECT COUNT(*) FROM comptetresorerie c WHERE c.cptActif = 1) AS nbComptes;
END$$

DROP PROCEDURE IF EXISTS SP_Stats_Mensuel$$
CREATE PROCEDURE SP_Stats_Mensuel(IN p_annee INT)
BEGIN
  SELECT n.mois,
         COALESCE(SUM(CASE WHEN m.mvtType = 'RECETTE' THEN m.mvtMontant END), 0) AS recettes,
         COALESCE(SUM(CASE WHEN m.mvtType = 'DEPENSE' THEN m.mvtMontant END), 0) AS depenses
    FROM (SELECT 1 AS mois UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6
          UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12) n
    LEFT JOIN mouvement m ON MONTH(m.mvtDate) = n.mois AND YEAR(m.mvtDate) = p_annee
   GROUP BY n.mois
   ORDER BY n.mois;
END$$

DROP PROCEDURE IF EXISTS SP_Stats_ParCategorie$$
CREATE PROCEDURE SP_Stats_ParCategorie(IN p_type VARCHAR(10), IN p_debut DATE, IN p_fin DATE)
BEGIN
  SELECT k.catLibelle AS libelle, k.catType AS typeCat, COUNT(*) AS nb, SUM(m.mvtMontant) AS total
    FROM mouvement m JOIN categorie k ON k.categorieId = m.categorieId
   WHERE m.mvtDate BETWEEN p_debut AND p_fin
     AND (p_type IS NULL OR p_type = '' OR m.mvtType = p_type)
   GROUP BY k.categorieId, k.catLibelle, k.catType
   ORDER BY total DESC;
END$$

DROP PROCEDURE IF EXISTS SP_Stats_ParCentre$$
CREATE PROCEDURE SP_Stats_ParCentre(IN p_debut DATE, IN p_fin DATE)
BEGIN
  SELECT COALESCE(ci.ctrCode, '-') AS code, COALESCE(ci.ctrLibelle, 'Non impute') AS libelle,
         COALESCE(SUM(CASE WHEN m.mvtType = 'RECETTE' THEN m.mvtMontant END), 0) AS recettes,
         COALESCE(SUM(CASE WHEN m.mvtType = 'DEPENSE' THEN m.mvtMontant END), 0) AS depenses
    FROM mouvement m LEFT JOIN centreimputation ci ON ci.centreId = m.centreId
   WHERE m.mvtDate BETWEEN p_debut AND p_fin
   GROUP BY ci.centreId, ci.ctrCode, ci.ctrLibelle
   ORDER BY depenses DESC;
END$$

DELIMITER ;
