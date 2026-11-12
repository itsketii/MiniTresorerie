namespace MiniTresorerie.UInterface
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDroite = new System.Windows.Forms.Panel();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.pnlEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMotDePasse = new System.Windows.Forms.Button();
            this.pnlEnteteLigne = new System.Windows.Forms.Panel();
            this.pnlLateral = new MiniTresorerie.UInterface.Composants.PanelDegrade();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnNavTableau = new System.Windows.Forms.Button();
            this.lblSecTreso = new System.Windows.Forms.Label();
            this.btnNavComptes = new System.Windows.Forms.Button();
            this.btnNavMouvements = new System.Windows.Forms.Button();
            this.btnNavRapprochement = new System.Windows.Forms.Button();
            this.lblSecAnalyse = new System.Windows.Forms.Label();
            this.btnNavRapports = new System.Windows.Forms.Button();
            this.lblSecParam = new System.Windows.Forms.Label();
            this.btnNavCategories = new System.Windows.Forms.Button();
            this.btnNavCentres = new System.Windows.Forms.Button();
            this.btnNavModes = new System.Windows.Forms.Button();
            this.btnNavTypes = new System.Windows.Forms.Button();
            this.btnNavUtilisateurs = new System.Windows.Forms.Button();
            this.pnlPied = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblInitiales = new System.Windows.Forms.Label();
            this.lblUserNom = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.logo = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblMarqueSous = new System.Windows.Forms.Label();
            this.pnlDroite.SuspendLayout();
            this.pnlEntete.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlPied.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDroite
            // 
            this.pnlDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDroite.Size = new System.Drawing.Size(916, 700);
            this.pnlDroite.TabIndex = 0;
            this.pnlDroite.Controls.Add(this.pnlContenu);
            this.pnlDroite.Controls.Add(this.pnlEntete);
            // 
            // pnlContenu
            // 
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlContenu.Size = new System.Drawing.Size(916, 624);
            this.pnlContenu.TabIndex = 0;
            // 
            // pnlEntete
            // 
            this.pnlEntete.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntete.Size = new System.Drawing.Size(916, 76);
            this.pnlEntete.TabIndex = 1;
            this.pnlEntete.Controls.Add(this.lblTitre);
            this.pnlEntete.Controls.Add(this.lblSousTitre);
            this.pnlEntete.Controls.Add(this.lblDate);
            this.pnlEntete.Controls.Add(this.btnMotDePasse);
            this.pnlEntete.Controls.Add(this.pnlEnteteLigne);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTitre.Location = new System.Drawing.Point(28, 10);
            this.lblTitre.Text = "Tableau de bord";
            this.lblTitre.TabIndex = 0;
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSousTitre.Location = new System.Drawing.Point(29, 46);
            this.lblSousTitre.Text = "Vue d'ensemble de votre trésorerie";
            this.lblSousTitre.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDate.Location = new System.Drawing.Point(406, 26);
            this.lblDate.Size = new System.Drawing.Size(300, 26);
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Text = "";
            this.lblDate.TabIndex = 2;
            // 
            // btnMotDePasse
            // 
            this.btnMotDePasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMotDePasse.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnMotDePasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotDePasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotDePasse.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnMotDePasse.Location = new System.Drawing.Point(722, 19);
            this.btnMotDePasse.Size = new System.Drawing.Size(170, 38);
            this.btnMotDePasse.Text = "Mon mot de passe";
            this.btnMotDePasse.UseVisualStyleBackColor = false;
            this.btnMotDePasse.TabIndex = 3;
            this.btnMotDePasse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnMotDePasse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnMotDePasse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnMotDePasse.Click += new System.EventHandler(this.btnMotDePasse_Click);
            // 
            // pnlEnteteLigne
            // 
            this.pnlEnteteLigne.BackColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.pnlEnteteLigne.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEnteteLigne.Size = new System.Drawing.Size(916, 1);
            this.pnlEnteteLigne.TabIndex = 4;
            // 
            // pnlLateral
            // 
            this.pnlLateral.Angle = 90F;
            this.pnlLateral.Debut = System.Drawing.Color.FromArgb(2, 44, 34);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Fin = System.Drawing.Color.FromArgb(6, 78, 59);
            this.pnlLateral.Size = new System.Drawing.Size(264, 700);
            this.pnlLateral.TabIndex = 1;
            this.pnlLateral.Controls.Add(this.pnlNav);
            this.pnlLateral.Controls.Add(this.pnlPied);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            // 
            // pnlNav
            // 
            this.pnlNav.AutoScroll = true;
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Size = new System.Drawing.Size(264, 482);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.Controls.Add(this.btnNavTableau);
            this.pnlNav.Controls.Add(this.lblSecTreso);
            this.pnlNav.Controls.Add(this.btnNavComptes);
            this.pnlNav.Controls.Add(this.btnNavMouvements);
            this.pnlNav.Controls.Add(this.btnNavRapprochement);
            this.pnlNav.Controls.Add(this.lblSecAnalyse);
            this.pnlNav.Controls.Add(this.btnNavRapports);
            this.pnlNav.Controls.Add(this.lblSecParam);
            this.pnlNav.Controls.Add(this.btnNavCategories);
            this.pnlNav.Controls.Add(this.btnNavCentres);
            this.pnlNav.Controls.Add(this.btnNavModes);
            this.pnlNav.Controls.Add(this.btnNavTypes);
            this.pnlNav.Controls.Add(this.btnNavUtilisateurs);
            // 
            // btnNavTableau
            // 
            this.btnNavTableau.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTableau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTableau.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTableau.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavTableau.Location = new System.Drawing.Point(0, 4);
            this.btnNavTableau.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavTableau.Size = new System.Drawing.Size(264, 42);
            this.btnNavTableau.Text = "Tableau de bord";
            this.btnNavTableau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTableau.UseVisualStyleBackColor = false;
            this.btnNavTableau.TabIndex = 0;
            this.btnNavTableau.FlatAppearance.BorderSize = 0;
            this.btnNavTableau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavTableau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavTableau.Click += new System.EventHandler(this.Nav_Click);
            // 
            // lblSecTreso
            // 
            this.lblSecTreso.AutoSize = true;
            this.lblSecTreso.BackColor = System.Drawing.Color.Transparent;
            this.lblSecTreso.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTreso.ForeColor = System.Drawing.Color.FromArgb(110, 170, 145);
            this.lblSecTreso.Location = new System.Drawing.Point(26, 62);
            this.lblSecTreso.Text = "TRÉSORERIE";
            this.lblSecTreso.TabIndex = 1;
            // 
            // btnNavComptes
            // 
            this.btnNavComptes.BackColor = System.Drawing.Color.Transparent;
            this.btnNavComptes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavComptes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavComptes.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavComptes.Location = new System.Drawing.Point(0, 84);
            this.btnNavComptes.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavComptes.Size = new System.Drawing.Size(264, 42);
            this.btnNavComptes.Text = "Comptes";
            this.btnNavComptes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavComptes.UseVisualStyleBackColor = false;
            this.btnNavComptes.TabIndex = 2;
            this.btnNavComptes.FlatAppearance.BorderSize = 0;
            this.btnNavComptes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavComptes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavComptes.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavMouvements
            // 
            this.btnNavMouvements.BackColor = System.Drawing.Color.Transparent;
            this.btnNavMouvements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMouvements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMouvements.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMouvements.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavMouvements.Location = new System.Drawing.Point(0, 126);
            this.btnNavMouvements.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavMouvements.Size = new System.Drawing.Size(264, 42);
            this.btnNavMouvements.Text = "Mouvements";
            this.btnNavMouvements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMouvements.UseVisualStyleBackColor = false;
            this.btnNavMouvements.TabIndex = 3;
            this.btnNavMouvements.FlatAppearance.BorderSize = 0;
            this.btnNavMouvements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavMouvements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavMouvements.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavRapprochement
            // 
            this.btnNavRapprochement.BackColor = System.Drawing.Color.Transparent;
            this.btnNavRapprochement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRapprochement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRapprochement.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRapprochement.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavRapprochement.Location = new System.Drawing.Point(0, 168);
            this.btnNavRapprochement.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavRapprochement.Size = new System.Drawing.Size(264, 42);
            this.btnNavRapprochement.Text = "Rapprochement";
            this.btnNavRapprochement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRapprochement.UseVisualStyleBackColor = false;
            this.btnNavRapprochement.TabIndex = 4;
            this.btnNavRapprochement.FlatAppearance.BorderSize = 0;
            this.btnNavRapprochement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavRapprochement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavRapprochement.Click += new System.EventHandler(this.Nav_Click);
            // 
            // lblSecAnalyse
            // 
            this.lblSecAnalyse.AutoSize = true;
            this.lblSecAnalyse.BackColor = System.Drawing.Color.Transparent;
            this.lblSecAnalyse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecAnalyse.ForeColor = System.Drawing.Color.FromArgb(110, 170, 145);
            this.lblSecAnalyse.Location = new System.Drawing.Point(26, 224);
            this.lblSecAnalyse.Text = "ANALYSE";
            this.lblSecAnalyse.TabIndex = 5;
            // 
            // btnNavRapports
            // 
            this.btnNavRapports.BackColor = System.Drawing.Color.Transparent;
            this.btnNavRapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRapports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRapports.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRapports.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavRapports.Location = new System.Drawing.Point(0, 246);
            this.btnNavRapports.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavRapports.Size = new System.Drawing.Size(264, 42);
            this.btnNavRapports.Text = "Rapports et états";
            this.btnNavRapports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRapports.UseVisualStyleBackColor = false;
            this.btnNavRapports.TabIndex = 6;
            this.btnNavRapports.FlatAppearance.BorderSize = 0;
            this.btnNavRapports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavRapports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavRapports.Click += new System.EventHandler(this.Nav_Click);
            // 
            // lblSecParam
            // 
            this.lblSecParam.AutoSize = true;
            this.lblSecParam.BackColor = System.Drawing.Color.Transparent;
            this.lblSecParam.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecParam.ForeColor = System.Drawing.Color.FromArgb(110, 170, 145);
            this.lblSecParam.Location = new System.Drawing.Point(26, 302);
            this.lblSecParam.Text = "PARAMÈTRES";
            this.lblSecParam.TabIndex = 7;
            // 
            // btnNavCategories
            // 
            this.btnNavCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCategories.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCategories.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavCategories.Location = new System.Drawing.Point(0, 324);
            this.btnNavCategories.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavCategories.Size = new System.Drawing.Size(264, 42);
            this.btnNavCategories.Text = "Catégories";
            this.btnNavCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCategories.UseVisualStyleBackColor = false;
            this.btnNavCategories.TabIndex = 8;
            this.btnNavCategories.FlatAppearance.BorderSize = 0;
            this.btnNavCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavCategories.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavCentres
            // 
            this.btnNavCentres.BackColor = System.Drawing.Color.Transparent;
            this.btnNavCentres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCentres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCentres.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCentres.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavCentres.Location = new System.Drawing.Point(0, 366);
            this.btnNavCentres.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavCentres.Size = new System.Drawing.Size(264, 42);
            this.btnNavCentres.Text = "Centres d'imputation";
            this.btnNavCentres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCentres.UseVisualStyleBackColor = false;
            this.btnNavCentres.TabIndex = 9;
            this.btnNavCentres.FlatAppearance.BorderSize = 0;
            this.btnNavCentres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavCentres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavCentres.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavModes
            // 
            this.btnNavModes.BackColor = System.Drawing.Color.Transparent;
            this.btnNavModes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavModes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavModes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavModes.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavModes.Location = new System.Drawing.Point(0, 408);
            this.btnNavModes.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavModes.Size = new System.Drawing.Size(264, 42);
            this.btnNavModes.Text = "Modes de paiement";
            this.btnNavModes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavModes.UseVisualStyleBackColor = false;
            this.btnNavModes.TabIndex = 10;
            this.btnNavModes.FlatAppearance.BorderSize = 0;
            this.btnNavModes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavModes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavModes.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavTypes
            // 
            this.btnNavTypes.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTypes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTypes.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavTypes.Location = new System.Drawing.Point(0, 450);
            this.btnNavTypes.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavTypes.Size = new System.Drawing.Size(264, 42);
            this.btnNavTypes.Text = "Types de compte";
            this.btnNavTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTypes.UseVisualStyleBackColor = false;
            this.btnNavTypes.TabIndex = 11;
            this.btnNavTypes.FlatAppearance.BorderSize = 0;
            this.btnNavTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavTypes.Click += new System.EventHandler(this.Nav_Click);
            // 
            // btnNavUtilisateurs
            // 
            this.btnNavUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUtilisateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavUtilisateurs.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnNavUtilisateurs.Location = new System.Drawing.Point(0, 492);
            this.btnNavUtilisateurs.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnNavUtilisateurs.Size = new System.Drawing.Size(264, 42);
            this.btnNavUtilisateurs.Text = "Utilisateurs";
            this.btnNavUtilisateurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUtilisateurs.UseVisualStyleBackColor = false;
            this.btnNavUtilisateurs.TabIndex = 12;
            this.btnNavUtilisateurs.FlatAppearance.BorderSize = 0;
            this.btnNavUtilisateurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnNavUtilisateurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnNavUtilisateurs.Click += new System.EventHandler(this.Nav_Click);
            // 
            // pnlPied
            // 
            this.pnlPied.BackColor = System.Drawing.Color.Transparent;
            this.pnlPied.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPied.Size = new System.Drawing.Size(264, 126);
            this.pnlPied.TabIndex = 1;
            this.pnlPied.Controls.Add(this.pnlUser);
            this.pnlPied.Controls.Add(this.btnDeconnexion);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.pnlUser.Location = new System.Drawing.Point(16, 14);
            this.pnlUser.Size = new System.Drawing.Size(232, 56);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.Controls.Add(this.lblInitiales);
            this.pnlUser.Controls.Add(this.lblUserNom);
            this.pnlUser.Controls.Add(this.lblUserRole);
            // 
            // lblInitiales
            // 
            this.lblInitiales.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblInitiales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitiales.ForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            this.lblInitiales.Size = new System.Drawing.Size(40, 40);
            this.lblInitiales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInitiales.Text = "KK";
            this.lblInitiales.Location = new System.Drawing.Point(8, 8);
            this.lblInitiales.TabIndex = 0;
            // 
            // lblUserNom
            // 
            this.lblUserNom.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNom.AutoEllipsis = true;
            this.lblUserNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNom.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblUserNom.Size = new System.Drawing.Size(168, 22);
            this.lblUserNom.Text = "";
            this.lblUserNom.Location = new System.Drawing.Point(56, 8);
            this.lblUserNom.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.AutoEllipsis = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.lblUserRole.Size = new System.Drawing.Size(168, 20);
            this.lblUserRole.Text = "";
            this.lblUserRole.Location = new System.Drawing.Point(56, 30);
            this.lblUserRole.TabIndex = 2;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 78);
            this.btnDeconnexion.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnDeconnexion.Size = new System.Drawing.Size(264, 42);
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 95, 70);
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Size = new System.Drawing.Size(264, 92);
            this.pnlLogo.TabIndex = 2;
            this.pnlLogo.Controls.Add(this.logo);
            this.pnlLogo.Controls.Add(this.lblMarque);
            this.pnlLogo.Controls.Add(this.lblMarqueSous);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(24, 22);
            this.logo.Size = new System.Drawing.Size(48, 48);
            this.logo.TabIndex = 0;
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.BackColor = System.Drawing.Color.Transparent;
            this.lblMarque.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblMarque.Location = new System.Drawing.Point(82, 24);
            this.lblMarque.Text = "Mini Trésorerie";
            this.lblMarque.TabIndex = 1;
            // 
            // lblMarqueSous
            // 
            this.lblMarqueSous.AutoSize = true;
            this.lblMarqueSous.BackColor = System.Drawing.Color.Transparent;
            this.lblMarqueSous.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueSous.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblMarqueSous.Location = new System.Drawing.Point(83, 52);
            this.lblMarqueSous.Text = "GESTION FINANCIÈRE";
            this.lblMarqueSous.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.Controls.Add(this.pnlDroite);
            this.Controls.Add(this.pnlLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Trésorerie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlPied.ResumeLayout(false);
            this.pnlPied.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.pnlDroite.ResumeLayout(false);
            this.pnlDroite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlDroite;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Panel pnlEntete;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMotDePasse;
        private System.Windows.Forms.Panel pnlEnteteLigne;
        private MiniTresorerie.UInterface.Composants.PanelDegrade pnlLateral;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnNavTableau;
        private System.Windows.Forms.Label lblSecTreso;
        private System.Windows.Forms.Button btnNavComptes;
        private System.Windows.Forms.Button btnNavMouvements;
        private System.Windows.Forms.Button btnNavRapprochement;
        private System.Windows.Forms.Label lblSecAnalyse;
        private System.Windows.Forms.Button btnNavRapports;
        private System.Windows.Forms.Label lblSecParam;
        private System.Windows.Forms.Button btnNavCategories;
        private System.Windows.Forms.Button btnNavCentres;
        private System.Windows.Forms.Button btnNavModes;
        private System.Windows.Forms.Button btnNavTypes;
        private System.Windows.Forms.Button btnNavUtilisateurs;
        private System.Windows.Forms.Panel pnlPied;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblInitiales;
        private System.Windows.Forms.Label lblUserNom;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel pnlLogo;
        private MiniTresorerie.UInterface.Composants.LogoControl logo;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblMarqueSous;
    }
}
