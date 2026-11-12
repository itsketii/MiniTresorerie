namespace MiniTresorerie.UInterface
{
    partial class FrmConnexion
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
            this.logoDroite = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblMarqueSous = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.lblConsigne = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.chkAfficher = new System.Windows.Forms.CheckBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblPied = new System.Windows.Forms.Label();
            this.pnlIllustration = new MiniTresorerie.UInterface.Composants.PanneauIllustration();
            this.logoGauche = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblMarqueG = new System.Windows.Forms.Label();
            this.lblMarqueGSous = new System.Windows.Forms.Label();
            this.lblSlogan1 = new System.Windows.Forms.Label();
            this.lblSlogan2 = new System.Windows.Forms.Label();
            this.puce1 = new MiniTresorerie.UInterface.Composants.PuceCoche();
            this.lblAvantage1 = new System.Windows.Forms.Label();
            this.puce2 = new MiniTresorerie.UInterface.Composants.PuceCoche();
            this.lblAvantage2 = new System.Windows.Forms.Label();
            this.puce3 = new MiniTresorerie.UInterface.Composants.PuceCoche();
            this.lblAvantage3 = new System.Windows.Forms.Label();
            this.pnlIllustration.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoDroite
            // 
            this.logoDroite.Location = new System.Drawing.Point(560, 50);
            this.logoDroite.Size = new System.Drawing.Size(48, 48);
            this.logoDroite.TabIndex = 0;
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblMarque.Location = new System.Drawing.Point(620, 50);
            this.lblMarque.Text = "Mini Trésorerie";
            this.lblMarque.TabIndex = 1;
            // 
            // lblMarqueSous
            // 
            this.lblMarqueSous.AutoSize = true;
            this.lblMarqueSous.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueSous.ForeColor = System.Drawing.Color.FromArgb(176, 140, 28);
            this.lblMarqueSous.Location = new System.Drawing.Point(621, 78);
            this.lblMarqueSous.Text = "GESTION FINANCIÈRE";
            this.lblMarqueSous.TabIndex = 2;
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(932, 10);
            this.btnFermer.Size = new System.Drawing.Size(36, 32);
            this.btnFermer.Text = "×";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnFermer.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblBienvenue.Location = new System.Drawing.Point(560, 140);
            this.lblBienvenue.Text = "Connexion";
            this.lblBienvenue.TabIndex = 4;
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigne.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblConsigne.Location = new System.Drawing.Point(560, 196);
            this.lblConsigne.Text = "Identifiez-vous pour accéder à votre espace de travail.";
            this.lblConsigne.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblLogin.Location = new System.Drawing.Point(560, 246);
            this.lblLogin.Text = "Identifiant";
            this.lblLogin.TabIndex = 6;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtLogin.Location = new System.Drawing.Point(560, 270);
            this.txtLogin.PlaceholderText = "Votre identifiant";
            this.txtLogin.Size = new System.Drawing.Size(360, 29);
            this.txtLogin.TabIndex = 7;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblMdp.Location = new System.Drawing.Point(560, 330);
            this.lblMdp.Text = "Mot de passe";
            this.lblMdp.TabIndex = 8;
            // 
            // txtMdp
            // 
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtMdp.Location = new System.Drawing.Point(560, 354);
            this.txtMdp.PlaceholderText = "Votre mot de passe";
            this.txtMdp.Size = new System.Drawing.Size(360, 29);
            this.txtMdp.UseSystemPasswordChar = true;
            this.txtMdp.TabIndex = 9;
            // 
            // chkAfficher
            // 
            this.chkAfficher.AutoSize = true;
            this.chkAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAfficher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAfficher.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.chkAfficher.Location = new System.Drawing.Point(560, 400);
            this.chkAfficher.Size = new System.Drawing.Size(300, 27);
            this.chkAfficher.Text = "Afficher le mot de passe";
            this.chkAfficher.UseVisualStyleBackColor = true;
            this.chkAfficher.TabIndex = 10;
            this.chkAfficher.CheckedChanged += new System.EventHandler(this.chkAfficher_CheckedChanged);
            // 
            // lblErreur
            // 
            this.lblErreur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblErreur.Location = new System.Drawing.Point(560, 430);
            this.lblErreur.Size = new System.Drawing.Size(360, 38);
            this.lblErreur.Text = "";
            this.lblErreur.TabIndex = 11;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnConnexion.Location = new System.Drawing.Point(560, 474);
            this.btnConnexion.Size = new System.Drawing.Size(360, 50);
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.TabIndex = 12;
            this.btnConnexion.FlatAppearance.BorderSize = 0;
            this.btnConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblPied
            // 
            this.lblPied.AutoSize = true;
            this.lblPied.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPied.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPied.Location = new System.Drawing.Point(560, 556);
            this.lblPied.Text = "© 2026 Mini Trésorerie  ·  Version 1.0";
            this.lblPied.TabIndex = 13;
            // 
            // pnlIllustration
            // 
            this.pnlIllustration.Angle = 55F;
            this.pnlIllustration.Debut = System.Drawing.Color.FromArgb(2, 44, 34);
            this.pnlIllustration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIllustration.Fin = System.Drawing.Color.FromArgb(4, 120, 87);
            this.pnlIllustration.Size = new System.Drawing.Size(500, 600);
            this.pnlIllustration.TabIndex = 14;
            this.pnlIllustration.Controls.Add(this.logoGauche);
            this.pnlIllustration.Controls.Add(this.lblMarqueG);
            this.pnlIllustration.Controls.Add(this.lblMarqueGSous);
            this.pnlIllustration.Controls.Add(this.lblSlogan1);
            this.pnlIllustration.Controls.Add(this.lblSlogan2);
            this.pnlIllustration.Controls.Add(this.puce1);
            this.pnlIllustration.Controls.Add(this.lblAvantage1);
            this.pnlIllustration.Controls.Add(this.puce2);
            this.pnlIllustration.Controls.Add(this.lblAvantage2);
            this.pnlIllustration.Controls.Add(this.puce3);
            this.pnlIllustration.Controls.Add(this.lblAvantage3);
            // 
            // logoGauche
            // 
            this.logoGauche.Location = new System.Drawing.Point(40, 40);
            this.logoGauche.Size = new System.Drawing.Size(60, 60);
            this.logoGauche.TabIndex = 0;
            // 
            // lblMarqueG
            // 
            this.lblMarqueG.AutoSize = true;
            this.lblMarqueG.BackColor = System.Drawing.Color.Transparent;
            this.lblMarqueG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueG.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblMarqueG.Location = new System.Drawing.Point(112, 50);
            this.lblMarqueG.Text = "MINI TRÉSORERIE";
            this.lblMarqueG.TabIndex = 1;
            // 
            // lblMarqueGSous
            // 
            this.lblMarqueGSous.AutoSize = true;
            this.lblMarqueGSous.BackColor = System.Drawing.Color.Transparent;
            this.lblMarqueGSous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarqueGSous.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblMarqueGSous.Location = new System.Drawing.Point(112, 76);
            this.lblMarqueGSous.Text = "Comptes · Mouvements · Analyse";
            this.lblMarqueGSous.TabIndex = 2;
            // 
            // lblSlogan1
            // 
            this.lblSlogan1.AutoSize = true;
            this.lblSlogan1.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblSlogan1.Location = new System.Drawing.Point(40, 138);
            this.lblSlogan1.Text = "Pilotez votre trésorerie";
            this.lblSlogan1.TabIndex = 3;
            // 
            // lblSlogan2
            // 
            this.lblSlogan2.AutoSize = true;
            this.lblSlogan2.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan2.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblSlogan2.Location = new System.Drawing.Point(40, 184);
            this.lblSlogan2.Text = "en toute sérénité.";
            this.lblSlogan2.TabIndex = 4;
            // 
            // puce1
            // 
            this.puce1.Location = new System.Drawing.Point(40, 252);
            this.puce1.Size = new System.Drawing.Size(22, 22);
            this.puce1.TabIndex = 5;
            // 
            // lblAvantage1
            // 
            this.lblAvantage1.AutoSize = true;
            this.lblAvantage1.BackColor = System.Drawing.Color.Transparent;
            this.lblAvantage1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvantage1.ForeColor = System.Drawing.Color.FromArgb(226, 244, 236);
            this.lblAvantage1.Location = new System.Drawing.Point(74, 252);
            this.lblAvantage1.Text = "Recettes et dépenses suivies en temps réel";
            this.lblAvantage1.TabIndex = 6;
            // 
            // puce2
            // 
            this.puce2.Location = new System.Drawing.Point(40, 286);
            this.puce2.Size = new System.Drawing.Size(22, 22);
            this.puce2.TabIndex = 7;
            // 
            // lblAvantage2
            // 
            this.lblAvantage2.AutoSize = true;
            this.lblAvantage2.BackColor = System.Drawing.Color.Transparent;
            this.lblAvantage2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvantage2.ForeColor = System.Drawing.Color.FromArgb(226, 244, 236);
            this.lblAvantage2.Location = new System.Drawing.Point(74, 286);
            this.lblAvantage2.Text = "Analyse par centre d'imputation analytique";
            this.lblAvantage2.TabIndex = 8;
            // 
            // puce3
            // 
            this.puce3.Location = new System.Drawing.Point(40, 320);
            this.puce3.Size = new System.Drawing.Size(22, 22);
            this.puce3.TabIndex = 9;
            // 
            // lblAvantage3
            // 
            this.lblAvantage3.AutoSize = true;
            this.lblAvantage3.BackColor = System.Drawing.Color.Transparent;
            this.lblAvantage3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvantage3.ForeColor = System.Drawing.Color.FromArgb(226, 244, 236);
            this.lblAvantage3.Location = new System.Drawing.Point(74, 320);
            this.lblAvantage3.Text = "États imprimables : PDF et Excel";
            this.lblAvantage3.TabIndex = 10;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnConnexion;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.logoDroite);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblMarqueSous);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.lblConsigne);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.chkAfficher);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblPied);
            this.Controls.Add(this.pnlIllustration);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Trésorerie — Connexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            this.pnlIllustration.ResumeLayout(false);
            this.pnlIllustration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MiniTresorerie.UInterface.Composants.LogoControl logoDroite;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblMarqueSous;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.CheckBox chkAfficher;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblPied;
        private MiniTresorerie.UInterface.Composants.PanneauIllustration pnlIllustration;
        private MiniTresorerie.UInterface.Composants.LogoControl logoGauche;
        private System.Windows.Forms.Label lblMarqueG;
        private System.Windows.Forms.Label lblMarqueGSous;
        private System.Windows.Forms.Label lblSlogan1;
        private System.Windows.Forms.Label lblSlogan2;
        private MiniTresorerie.UInterface.Composants.PuceCoche puce1;
        private System.Windows.Forms.Label lblAvantage1;
        private MiniTresorerie.UInterface.Composants.PuceCoche puce2;
        private System.Windows.Forms.Label lblAvantage2;
        private MiniTresorerie.UInterface.Composants.PuceCoche puce3;
        private System.Windows.Forms.Label lblAvantage3;
    }
}
