-- =====================================================================
--  DONNÉES INITIALES + JEU DE DÉMONSTRATION
--  Comptes de connexion :
--     admin      / Admin@123     (Admin)
--     comptable  / Compta@123    (Comptable)
--     lecteur    / Lecteur@123   (Lecteur)
-- =====================================================================
USE dbMiniTresorerie;

INSERT INTO roleutilisateur(roleLibelle, roleDescription) VALUES
 ('Admin',     'Acces complet, gestion des utilisateurs et des parametres'),
 ('Comptable', 'Saisie et suivi des operations, rapports, rapprochement'),
 ('Lecteur',   'Consultation seule');

-- Utilisateurs : mot de passe = SHA2(sel + mot de passe, 256)
SET @s1 = UUID(); SET @s2 = UUID(); SET @s3 = UUID();
INSERT INTO utilisateur(usrNom, usrPrenom, usrLogin, usrSel, usrMotDePasse, roleId) VALUES
 ('Administrateur', 'Systeme', 'admin',     @s1, SHA2(CONCAT(@s1, 'Admin@123'), 256),   (SELECT roleId FROM roleutilisateur WHERE roleLibelle = 'Admin')),
 ('Traore',         'Awa',     'comptable', @s2, SHA2(CONCAT(@s2, 'Compta@123'), 256),  (SELECT roleId FROM roleutilisateur WHERE roleLibelle = 'Comptable')),
 ('Kouassi',        'Yao',     'lecteur',   @s3, SHA2(CONCAT(@s3, 'Lecteur@123'), 256), (SELECT roleId FROM roleutilisateur WHERE roleLibelle = 'Lecteur'));

INSERT INTO typecompte(tcLibelle) VALUES ('Caisse'), ('Banque'), ('Mobile Money'), ('Epargne');

INSERT INTO modepaiement(mpLibelle) VALUES ('Especes'), ('Cheque'), ('Virement'), ('Mobile Money'), ('Carte bancaire');

INSERT INTO categorie(catLibelle, catType) VALUES
 ('Ventes', 'RECETTE'), ('Prestations de services', 'RECETTE'), ('Subventions', 'RECETTE'),
 ('Cotisations', 'RECETTE'), ('Interets bancaires', 'RECETTE'), ('Autres recettes', 'RECETTE'),
 ('Salaires', 'DEPENSE'), ('Loyer et charges', 'DEPENSE'), ('Fournitures de bureau', 'DEPENSE'),
 ('Transport et deplacements', 'DEPENSE'), ('Communication et internet', 'DEPENSE'),
 ('Maintenance et reparations', 'DEPENSE'), ('Impots et taxes', 'DEPENSE'), ('Autres depenses', 'DEPENSE');

INSERT INTO centreimputation(ctrCode, ctrLibelle, ctrResponsable, ctrDescription) VALUES
 ('ADM', 'Administration',            'Direction generale',    'Frais generaux et fonctionnement'),
 ('COM', 'Commercial et Marketing',   'Responsable commercial','Prospection, publicite, evenements clients'),
 ('TEC', 'Technique et Informatique', 'Responsable technique', 'Materiel, logiciels, maintenance'),
 ('RH',  'Ressources humaines',       'Responsable RH',        'Salaires, formation, recrutement'),
 ('PRJ', 'Projets et Evenements',     'Chef de projet',        'Projets speciaux');

INSERT INTO comptetresorerie(cptCode, cptLibelle, typeCompteId, cptDevise, cptSoldeInitial, cptDateOuverture, cptDescription) VALUES
 ('CAI-001', 'Caisse principale',          (SELECT typeCompteId FROM typecompte WHERE tcLibelle = 'Caisse'),        'FCFA',   500000, DATE_SUB(CURDATE(), INTERVAL 14 MONTH), 'Caisse du siege'),
 ('BAN-001', 'Compte courant - Banque A',  (SELECT typeCompteId FROM typecompte WHERE tcLibelle = 'Banque'),        'FCFA',  5000000, DATE_SUB(CURDATE(), INTERVAL 14 MONTH), 'Compte principal de l''entreprise'),
 ('BAN-002', 'Compte courant - Banque B',  (SELECT typeCompteId FROM typecompte WHERE tcLibelle = 'Banque'),        'FCFA',  2500000, DATE_SUB(CURDATE(), INTERVAL 14 MONTH), 'Compte secondaire'),
 ('MOM-001', 'Orange Money professionnel', (SELECT typeCompteId FROM typecompte WHERE tcLibelle = 'Mobile Money'), 'FCFA',   150000, DATE_SUB(CURDATE(), INTERVAL 14 MONTH), 'Paiements mobiles'),
 ('EPA-001', 'Epargne de precaution',      (SELECT typeCompteId FROM typecompte WHERE tcLibelle = 'Epargne'),       'FCFA',  1000000, DATE_SUB(CURDATE(), INTERVAL 14 MONTH), 'Reserve de securite');

-- Génération de mouvements de démonstration sur les 12 derniers mois
DELIMITER $$
DROP PROCEDURE IF EXISTS SP_Seed_Mouvements$$
CREATE PROCEDURE SP_Seed_Mouvements()
BEGIN
  DECLARE i INT DEFAULT 0;
  DECLARE v_date DATE;
  DECLARE v_type VARCHAR(10);
  DECLARE v_cat INT;
  DECLARE v_lib VARCHAR(80);
  DECLARE v_cpt INT;
  DECLARE v_mode INT;
  DECLARE v_centre INT;
  DECLARE v_mnt DECIMAL(15,2);
  DECLARE v_id INT;
  DECLARE v_pointe TINYINT;
  DECLARE v_user INT;
  SELECT utilisateurId INTO v_user FROM utilisateur WHERE usrLogin = 'comptable';

  WHILE i < 160 DO
    SET v_date = DATE_SUB(CURDATE(), INTERVAL FLOOR(RAND() * 360) DAY);
    SET v_type = IF(RAND() < 0.42, 'RECETTE', 'DEPENSE');
    SELECT categorieId, catLibelle INTO v_cat, v_lib FROM categorie WHERE catType = v_type ORDER BY RAND() LIMIT 1;
    SELECT compteId INTO v_cpt FROM comptetresorerie WHERE cptCode <> 'EPA-001' ORDER BY RAND() LIMIT 1;
    SELECT modePaiementId INTO v_mode FROM modepaiement ORDER BY RAND() LIMIT 1;
    SELECT centreId INTO v_centre FROM centreimputation ORDER BY RAND() LIMIT 1;
    SET v_mnt = IF(v_type = 'RECETTE', 50000 + FLOOR(RAND() * 20) * 25000, 10000 + FLOOR(RAND() * 40) * 5000);
    SET v_pointe = IF(v_date < DATE_SUB(CURDATE(), INTERVAL 60 DAY), 1, 0);

    INSERT INTO mouvement(mvtReference, mvtDate, mvtType, mvtLibelle, mvtMontant, compteId, categorieId, centreId,
                          modePaiementId, mvtTiers, mvtPiece, mvtRapproche, mvtDateRapprochement, utilisateurId)
    VALUES (UUID(), v_date, v_type, CONCAT(v_lib, ' - ', DATE_FORMAT(v_date, '%m/%Y')), v_mnt, v_cpt, v_cat, v_centre,
            v_mode, ELT(1 + FLOOR(RAND() * 6), 'SODECI', 'CIE', 'Orange CI', 'Fournisseur Alpha', 'Client Beta', 'Partenaire Gamma'),
            CONCAT('PJ-', LPAD(i + 1, 4, '0')), v_pointe, IF(v_pointe = 1, NOW(), NULL), v_user);
    SET v_id = LAST_INSERT_ID();
    UPDATE mouvement
       SET mvtReference = CONCAT(IF(v_type = 'RECETTE', 'REC', 'DEP'), '-', DATE_FORMAT(v_date, '%Y%m'), '-', LPAD(v_id, 5, '0'))
     WHERE mouvementId = v_id;
    SET i = i + 1;
  END WHILE;
END$$
DELIMITER ;

CALL SP_Seed_Mouvements();
DROP PROCEDURE SP_Seed_Mouvements;
