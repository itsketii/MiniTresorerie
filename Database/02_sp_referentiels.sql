-- =====================================================================
--  PROCÉDURES STOCKÉES — Référentiels (rôles, types de compte,
--  modes de paiement, catégories, centres d'imputation)
-- =====================================================================
USE dbMiniTresorerie;
DELIMITER $$

-- ===== ROLES =====
DROP PROCEDURE IF EXISTS SP_Role_ReadAll$$
CREATE PROCEDURE SP_Role_ReadAll()
BEGIN
  SELECT roleId, roleLibelle, roleDescription FROM roleutilisateur ORDER BY roleId;
END$$

-- ===== TYPE DE COMPTE =====
DROP PROCEDURE IF EXISTS SP_TypeCompte_Create$$
CREATE PROCEDURE SP_TypeCompte_Create(IN p_libelle VARCHAR(60), OUT p_id INT)
BEGIN
  INSERT INTO typecompte(tcLibelle) VALUES (p_libelle);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_TypeCompte_ReadAll$$
CREATE PROCEDURE SP_TypeCompte_ReadAll(IN p_filtre VARCHAR(200))
BEGIN
  SELECT typeCompteId, tcLibelle FROM typecompte
  WHERE p_filtre IS NULL OR p_filtre = '' OR tcLibelle LIKE CONCAT('%', p_filtre, '%')
  ORDER BY tcLibelle;
END$$

DROP PROCEDURE IF EXISTS SP_TypeCompte_ReadById$$
CREATE PROCEDURE SP_TypeCompte_ReadById(IN p_id INT)
BEGIN
  SELECT typeCompteId, tcLibelle FROM typecompte WHERE typeCompteId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_TypeCompte_Update$$
CREATE PROCEDURE SP_TypeCompte_Update(IN p_id INT, IN p_libelle VARCHAR(60))
BEGIN
  UPDATE typecompte SET tcLibelle = p_libelle WHERE typeCompteId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_TypeCompte_Delete$$
CREATE PROCEDURE SP_TypeCompte_Delete(IN p_id INT)
BEGIN
  DELETE FROM typecompte WHERE typeCompteId = p_id;
END$$

-- ===== MODE DE PAIEMENT =====
DROP PROCEDURE IF EXISTS SP_ModePaiement_Create$$
CREATE PROCEDURE SP_ModePaiement_Create(IN p_libelle VARCHAR(60), OUT p_id INT)
BEGIN
  INSERT INTO modepaiement(mpLibelle) VALUES (p_libelle);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_ModePaiement_ReadAll$$
CREATE PROCEDURE SP_ModePaiement_ReadAll(IN p_filtre VARCHAR(200))
BEGIN
  SELECT modePaiementId, mpLibelle FROM modepaiement
  WHERE p_filtre IS NULL OR p_filtre = '' OR mpLibelle LIKE CONCAT('%', p_filtre, '%')
  ORDER BY mpLibelle;
END$$

DROP PROCEDURE IF EXISTS SP_ModePaiement_ReadById$$
CREATE PROCEDURE SP_ModePaiement_ReadById(IN p_id INT)
BEGIN
  SELECT modePaiementId, mpLibelle FROM modepaiement WHERE modePaiementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_ModePaiement_Update$$
CREATE PROCEDURE SP_ModePaiement_Update(IN p_id INT, IN p_libelle VARCHAR(60))
BEGIN
  UPDATE modepaiement SET mpLibelle = p_libelle WHERE modePaiementId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_ModePaiement_Delete$$
CREATE PROCEDURE SP_ModePaiement_Delete(IN p_id INT)
BEGIN
  DELETE FROM modepaiement WHERE modePaiementId = p_id;
END$$

-- ===== CATEGORIE =====
DROP PROCEDURE IF EXISTS SP_Categorie_Create$$
CREATE PROCEDURE SP_Categorie_Create(IN p_libelle VARCHAR(80), IN p_type VARCHAR(10), OUT p_id INT)
BEGIN
  INSERT INTO categorie(catLibelle, catType) VALUES (p_libelle, p_type);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_Categorie_ReadAll$$
CREATE PROCEDURE SP_Categorie_ReadAll(IN p_filtre VARCHAR(200), IN p_type VARCHAR(10))
BEGIN
  SELECT categorieId, catLibelle, catType FROM categorie
  WHERE (p_filtre IS NULL OR p_filtre = '' OR catLibelle LIKE CONCAT('%', p_filtre, '%'))
    AND (p_type IS NULL OR p_type = '' OR catType = p_type)
  ORDER BY catType, catLibelle;
END$$

DROP PROCEDURE IF EXISTS SP_Categorie_ReadById$$
CREATE PROCEDURE SP_Categorie_ReadById(IN p_id INT)
BEGIN
  SELECT categorieId, catLibelle, catType FROM categorie WHERE categorieId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Categorie_Update$$
CREATE PROCEDURE SP_Categorie_Update(IN p_id INT, IN p_libelle VARCHAR(80), IN p_type VARCHAR(10))
BEGIN
  IF EXISTS (SELECT 1 FROM mouvement m WHERE m.categorieId = p_id AND m.mvtType <> p_type) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Impossible de changer le type : des mouvements de type different utilisent cette categorie.';
  END IF;
  UPDATE categorie SET catLibelle = p_libelle, catType = p_type WHERE categorieId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Categorie_Delete$$
CREATE PROCEDURE SP_Categorie_Delete(IN p_id INT)
BEGIN
  DELETE FROM categorie WHERE categorieId = p_id;
END$$

-- ===== CENTRE D'IMPUTATION ANALYTIQUE =====
DROP PROCEDURE IF EXISTS SP_Centre_Create$$
CREATE PROCEDURE SP_Centre_Create(IN p_code VARCHAR(10), IN p_libelle VARCHAR(100), IN p_responsable VARCHAR(100),
                                  IN p_description VARCHAR(255), IN p_actif TINYINT, OUT p_id INT)
BEGIN
  INSERT INTO centreimputation(ctrCode, ctrLibelle, ctrResponsable, ctrDescription, ctrActif)
  VALUES (p_code, p_libelle, p_responsable, p_description, p_actif);
  SET p_id = LAST_INSERT_ID();
END$$

DROP PROCEDURE IF EXISTS SP_Centre_ReadAll$$
CREATE PROCEDURE SP_Centre_ReadAll(IN p_filtre VARCHAR(200), IN p_actif TINYINT)
BEGIN
  SELECT centreId, ctrCode, ctrLibelle, ctrResponsable, ctrDescription, ctrActif FROM centreimputation
  WHERE (p_filtre IS NULL OR p_filtre = '' OR ctrCode LIKE CONCAT('%', p_filtre, '%')
         OR ctrLibelle LIKE CONCAT('%', p_filtre, '%') OR ctrResponsable LIKE CONCAT('%', p_filtre, '%'))
    AND (p_actif IS NULL OR ctrActif = p_actif)
  ORDER BY ctrCode;
END$$

DROP PROCEDURE IF EXISTS SP_Centre_ReadById$$
CREATE PROCEDURE SP_Centre_ReadById(IN p_id INT)
BEGIN
  SELECT centreId, ctrCode, ctrLibelle, ctrResponsable, ctrDescription, ctrActif FROM centreimputation WHERE centreId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Centre_Update$$
CREATE PROCEDURE SP_Centre_Update(IN p_id INT, IN p_code VARCHAR(10), IN p_libelle VARCHAR(100), IN p_responsable VARCHAR(100),
                                  IN p_description VARCHAR(255), IN p_actif TINYINT)
BEGIN
  UPDATE centreimputation SET ctrCode = p_code, ctrLibelle = p_libelle, ctrResponsable = p_responsable,
         ctrDescription = p_description, ctrActif = p_actif
  WHERE centreId = p_id;
END$$

DROP PROCEDURE IF EXISTS SP_Centre_Delete$$
CREATE PROCEDURE SP_Centre_Delete(IN p_id INT)
BEGIN
  DELETE FROM centreimputation WHERE centreId = p_id;
END$$

DELIMITER ;
