-- =====================================================================
--  MINI TRÉSORERIE — Schéma MySQL 8  (à exécuter en premier)
--  Base : dbMiniTresorerie
-- =====================================================================
DROP DATABASE IF EXISTS dbMiniTresorerie;
CREATE DATABASE dbMiniTresorerie CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE dbMiniTresorerie;

-- ---------- Sécurité -------------------------------------------------
CREATE TABLE roleutilisateur (
  roleId          INT AUTO_INCREMENT PRIMARY KEY,
  roleLibelle     VARCHAR(30)  NOT NULL,
  roleDescription VARCHAR(150) NULL,
  CONSTRAINT uq_role_libelle UNIQUE (roleLibelle)
) ENGINE=InnoDB;

CREATE TABLE utilisateur (
  utilisateurId        INT AUTO_INCREMENT PRIMARY KEY,
  usrNom               VARCHAR(60) NOT NULL,
  usrPrenom            VARCHAR(60) NOT NULL,
  usrLogin             VARCHAR(40) NOT NULL,
  usrSel               CHAR(36)    NOT NULL,            -- sel aléatoire (UUID)
  usrMotDePasse        CHAR(64)    NOT NULL,            -- SHA2(sel + mot de passe, 256)
  roleId               INT         NOT NULL,
  usrActif             TINYINT(1)  NOT NULL DEFAULT 1,
  usrDateCreation      DATETIME    NOT NULL DEFAULT CURRENT_TIMESTAMP,
  usrDerniereConnexion DATETIME    NULL,
  CONSTRAINT uq_usr_login UNIQUE (usrLogin),
  CONSTRAINT fk_usr_role  FOREIGN KEY (roleId) REFERENCES roleutilisateur(roleId)
) ENGINE=InnoDB;

-- ---------- Référentiels ---------------------------------------------
CREATE TABLE typecompte (
  typeCompteId INT AUTO_INCREMENT PRIMARY KEY,
  tcLibelle    VARCHAR(60) NOT NULL,
  CONSTRAINT uq_tc_libelle UNIQUE (tcLibelle)
) ENGINE=InnoDB;

CREATE TABLE modepaiement (
  modePaiementId INT AUTO_INCREMENT PRIMARY KEY,
  mpLibelle      VARCHAR(60) NOT NULL,
  CONSTRAINT uq_mp_libelle UNIQUE (mpLibelle)
) ENGINE=InnoDB;

CREATE TABLE categorie (
  categorieId INT AUTO_INCREMENT PRIMARY KEY,
  catLibelle  VARCHAR(80) NOT NULL,
  catType     ENUM('RECETTE','DEPENSE') NOT NULL,
  CONSTRAINT uq_cat UNIQUE (catLibelle, catType)
) ENGINE=InnoDB;

CREATE TABLE centreimputation (
  centreId       INT AUTO_INCREMENT PRIMARY KEY,
  ctrCode        VARCHAR(10)  NOT NULL,
  ctrLibelle     VARCHAR(100) NOT NULL,
  ctrResponsable VARCHAR(100) NULL,
  ctrDescription VARCHAR(255) NULL,
  ctrActif       TINYINT(1)   NOT NULL DEFAULT 1,
  CONSTRAINT uq_ctr_code UNIQUE (ctrCode)
) ENGINE=InnoDB;

-- ---------- Comptes de trésorerie ------------------------------------
CREATE TABLE comptetresorerie (
  compteId         INT AUTO_INCREMENT PRIMARY KEY,
  cptCode          VARCHAR(15)   NOT NULL,
  cptLibelle       VARCHAR(100)  NOT NULL,
  typeCompteId     INT           NOT NULL,
  cptDevise        VARCHAR(10)   NOT NULL DEFAULT 'FCFA',
  cptSoldeInitial  DECIMAL(15,2) NOT NULL DEFAULT 0,
  cptDateOuverture DATE          NOT NULL,
  cptActif         TINYINT(1)    NOT NULL DEFAULT 1,
  cptDescription   VARCHAR(255)  NULL,
  CONSTRAINT uq_cpt_code UNIQUE (cptCode),
  CONSTRAINT fk_cpt_type FOREIGN KEY (typeCompteId) REFERENCES typecompte(typeCompteId)
) ENGINE=InnoDB;

-- ---------- Mouvements (recettes / dépenses) -------------------------
CREATE TABLE mouvement (
  mouvementId          INT AUTO_INCREMENT PRIMARY KEY,
  mvtReference         VARCHAR(40)   NOT NULL,
  mvtDate              DATE          NOT NULL,
  mvtType              ENUM('RECETTE','DEPENSE') NOT NULL,
  mvtLibelle           VARCHAR(150)  NOT NULL,
  mvtMontant           DECIMAL(15,2) NOT NULL,
  compteId             INT           NOT NULL,
  categorieId          INT           NOT NULL,
  centreId             INT           NULL,
  modePaiementId       INT           NOT NULL,
  mvtTiers             VARCHAR(100)  NULL,
  mvtPiece             VARCHAR(60)   NULL,
  mvtRapproche         TINYINT(1)    NOT NULL DEFAULT 0,
  mvtDateRapprochement DATETIME      NULL,
  utilisateurId        INT           NOT NULL,
  mvtDateSaisie        DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT uq_mvt_ref      UNIQUE (mvtReference),
  CONSTRAINT ck_mvt_montant  CHECK (mvtMontant > 0),
  CONSTRAINT fk_mvt_compte   FOREIGN KEY (compteId)       REFERENCES comptetresorerie(compteId),
  CONSTRAINT fk_mvt_cat      FOREIGN KEY (categorieId)    REFERENCES categorie(categorieId),
  CONSTRAINT fk_mvt_centre   FOREIGN KEY (centreId)       REFERENCES centreimputation(centreId),
  CONSTRAINT fk_mvt_mode     FOREIGN KEY (modePaiementId) REFERENCES modepaiement(modePaiementId),
  CONSTRAINT fk_mvt_user     FOREIGN KEY (utilisateurId)  REFERENCES utilisateur(utilisateurId),
  INDEX ix_mvt_date (mvtDate),
  INDEX ix_mvt_compte_date (compteId, mvtDate)
) ENGINE=InnoDB;
