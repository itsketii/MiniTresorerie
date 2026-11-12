namespace MiniTresorerie.UInterface
{
    partial class FrmUtilisateurDetail
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
            this.pnlCorps = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMdp2 = new System.Windows.Forms.Label();
            this.txtMdp2 = new System.Windows.Forms.TextBox();
            this.lblActif = new System.Windows.Forms.Label();
            this.chkActif = new System.Windows.Forms.CheckBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlPied = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pnlEntete = new MiniTresorerie.UInterface.Composants.PanelDegrade();
            this.logo = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlLigneOr = new System.Windows.Forms.Panel();
            this.pnlCorps.SuspendLayout();
            this.pnlPied.SuspendLayout();
            this.pnlEntete.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCorps
            // 
            this.pnlCorps.AutoScroll = true;
            this.pnlCorps.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCorps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorps.Size = new System.Drawing.Size(700, 338);
            this.pnlCorps.TabIndex = 0;
            this.pnlCorps.Controls.Add(this.lblNom);
            this.pnlCorps.Controls.Add(this.txtNom);
            this.pnlCorps.Controls.Add(this.lblPrenom);
            this.pnlCorps.Controls.Add(this.txtPrenom);
            this.pnlCorps.Controls.Add(this.lblLogin);
            this.pnlCorps.Controls.Add(this.txtLogin);
            this.pnlCorps.Controls.Add(this.lblole);
            this.pnlCorps.Controls.Add(this.cbRole);
            this.pnlCorps.Controls.Add(this.lblMdp);
            this.pnlCorps.Controls.Add(this.txtMdp);
            this.pnlCorps.Controls.Add(this.lblMdp2);
            this.pnlCorps.Controls.Add(this.txtMdp2);
            this.pnlCorps.Controls.Add(this.lblActif);
            this.pnlCorps.Controls.Add(this.chkActif);
            this.pnlCorps.Controls.Add(this.lblNote);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblNom.Location = new System.Drawing.Point(28, 20);
            this.lblNom.Text = "Nom *";
            this.lblNom.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtNom.Location = new System.Drawing.Point(28, 44);
            this.txtNom.MaxLength = 60;
            this.txtNom.Size = new System.Drawing.Size(310, 29);
            this.txtNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblPrenom.Location = new System.Drawing.Point(354, 20);
            this.lblPrenom.Text = "Prénom *";
            this.lblPrenom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtPrenom.Location = new System.Drawing.Point(354, 44);
            this.txtPrenom.MaxLength = 60;
            this.txtPrenom.Size = new System.Drawing.Size(310, 29);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblLogin.Location = new System.Drawing.Point(28, 87);
            this.lblLogin.Text = "Identifiant de connexion *";
            this.lblLogin.TabIndex = 4;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtLogin.Location = new System.Drawing.Point(28, 111);
            this.txtLogin.MaxLength = 40;
            this.txtLogin.Size = new System.Drawing.Size(310, 29);
            this.txtLogin.TabIndex = 5;
            // 
            // lblole
            // 
            this.lblole.AutoSize = true;
            this.lblole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblole.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblole.Location = new System.Drawing.Point(354, 87);
            this.lblole.Text = "Rôle *";
            this.lblole.TabIndex = 6;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(354, 111);
            this.cbRole.Size = new System.Drawing.Size(310, 29);
            this.cbRole.TabIndex = 7;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblMdp.Location = new System.Drawing.Point(28, 154);
            this.lblMdp.Text = "Mot de passe";
            this.lblMdp.TabIndex = 8;
            // 
            // txtMdp
            // 
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtMdp.Location = new System.Drawing.Point(28, 178);
            this.txtMdp.MaxLength = 100;
            this.txtMdp.Size = new System.Drawing.Size(310, 29);
            this.txtMdp.UseSystemPasswordChar = true;
            this.txtMdp.TabIndex = 9;
            // 
            // lblMdp2
            // 
            this.lblMdp2.AutoSize = true;
            this.lblMdp2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp2.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblMdp2.Location = new System.Drawing.Point(354, 154);
            this.lblMdp2.Text = "Confirmation";
            this.lblMdp2.TabIndex = 10;
            // 
            // txtMdp2
            // 
            this.txtMdp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdp2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp2.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtMdp2.Location = new System.Drawing.Point(354, 178);
            this.txtMdp2.MaxLength = 100;
            this.txtMdp2.Size = new System.Drawing.Size(310, 29);
            this.txtMdp2.UseSystemPasswordChar = true;
            this.txtMdp2.TabIndex = 11;
            // 
            // lblActif
            // 
            this.lblActif.AutoSize = true;
            this.lblActif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActif.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblActif.Location = new System.Drawing.Point(28, 221);
            this.lblActif.Text = "Statut";
            this.lblActif.TabIndex = 12;
            // 
            // chkActif
            // 
            this.chkActif.AutoSize = true;
            this.chkActif.Checked = true;
            this.chkActif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActif.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActif.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.chkActif.Location = new System.Drawing.Point(28, 245);
            this.chkActif.Size = new System.Drawing.Size(310, 27);
            this.chkActif.Text = "Compte actif";
            this.chkActif.UseVisualStyleBackColor = true;
            this.chkActif.TabIndex = 13;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNote.Location = new System.Drawing.Point(28, 284);
            this.lblNote.Size = new System.Drawing.Size(636, 24);
            this.lblNote.Text = "Rôles : Admin = tout · Comptable = saisie et rapports · Lecteur = consultation seule.";
            this.lblNote.TabIndex = 14;
            // 
            // pnlPied
            // 
            this.pnlPied.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.pnlPied.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPied.Size = new System.Drawing.Size(700, 72);
            this.pnlPied.TabIndex = 1;
            this.pnlPied.Controls.Add(this.btnFermer);
            this.pnlPied.Controls.Add(this.btnEnregistrer);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnFermer.Location = new System.Drawing.Point(552, 15);
            this.btnFermer.Size = new System.Drawing.Size(120, 42);
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.TabIndex = 0;
            this.btnFermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEnregistrer.Location = new System.Drawing.Point(380, 15);
            this.btnEnregistrer.Size = new System.Drawing.Size(160, 42);
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // pnlEntete
            // 
            this.pnlEntete.Angle = 0F;
            this.pnlEntete.Debut = System.Drawing.Color.FromArgb(2, 44, 34);
            this.pnlEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntete.Fin = System.Drawing.Color.FromArgb(4, 120, 87);
            this.pnlEntete.Size = new System.Drawing.Size(700, 84);
            this.pnlEntete.TabIndex = 2;
            this.pnlEntete.Controls.Add(this.logo);
            this.pnlEntete.Controls.Add(this.lblTitre);
            this.pnlEntete.Controls.Add(this.lblSousTitre);
            this.pnlEntete.Controls.Add(this.pnlLigneOr);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(28, 18);
            this.logo.Size = new System.Drawing.Size(48, 48);
            this.logo.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitre.Location = new System.Drawing.Point(92, 16);
            this.lblTitre.Text = "Titre";
            this.lblTitre.TabIndex = 1;
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.lblSousTitre.Location = new System.Drawing.Point(93, 50);
            this.lblSousTitre.Text = "Renseignez les informations ci-dessous. Les champs marqués d'un * sont obligatoires.";
            this.lblSousTitre.TabIndex = 2;
            // 
            // pnlLigneOr
            // 
            this.pnlLigneOr.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.pnlLigneOr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLigneOr.Size = new System.Drawing.Size(700, 3);
            this.pnlLigneOr.TabIndex = 3;
            // 
            // FrmUtilisateurDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnEnregistrer;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(700, 494);
            this.Controls.Add(this.pnlCorps);
            this.Controls.Add(this.pnlPied);
            this.Controls.Add(this.pnlEntete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUtilisateurDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mini Trésorerie";
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.pnlPied.ResumeLayout(false);
            this.pnlPied.PerformLayout();
            this.pnlCorps.ResumeLayout(false);
            this.pnlCorps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlCorps;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMdp2;
        private System.Windows.Forms.TextBox txtMdp2;
        private System.Windows.Forms.Label lblActif;
        private System.Windows.Forms.CheckBox chkActif;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel pnlPied;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private MiniTresorerie.UInterface.Composants.PanelDegrade pnlEntete;
        private MiniTresorerie.UInterface.Composants.LogoControl logo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel pnlLigneOr;
    }
}
