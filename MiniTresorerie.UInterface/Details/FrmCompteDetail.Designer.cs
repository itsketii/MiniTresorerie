namespace MiniTresorerie.UInterface
{
    partial class FrmCompteDetail
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblype = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblDevise = new System.Windows.Forms.Label();
            this.txtDevise = new System.Windows.Forms.TextBox();
            this.lblSolde = new System.Windows.Forms.Label();
            this.nudSolde = new System.Windows.Forms.NumericUpDown();
            this.lblOuverture = new System.Windows.Forms.Label();
            this.dtOuverture = new System.Windows.Forms.DateTimePicker();
            this.lblActif = new System.Windows.Forms.Label();
            this.chkActif = new System.Windows.Forms.CheckBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.pnlPied = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pnlEntete = new MiniTresorerie.UInterface.Composants.PanelDegrade();
            this.logo = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlLigneOr = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSolde)).BeginInit();
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
            this.pnlCorps.Size = new System.Drawing.Size(700, 412);
            this.pnlCorps.TabIndex = 0;
            this.pnlCorps.Controls.Add(this.lblCode);
            this.pnlCorps.Controls.Add(this.txtCode);
            this.pnlCorps.Controls.Add(this.lblLibelle);
            this.pnlCorps.Controls.Add(this.txtLibelle);
            this.pnlCorps.Controls.Add(this.lblype);
            this.pnlCorps.Controls.Add(this.cbType);
            this.pnlCorps.Controls.Add(this.lblDevise);
            this.pnlCorps.Controls.Add(this.txtDevise);
            this.pnlCorps.Controls.Add(this.lblSolde);
            this.pnlCorps.Controls.Add(this.nudSolde);
            this.pnlCorps.Controls.Add(this.lblOuverture);
            this.pnlCorps.Controls.Add(this.dtOuverture);
            this.pnlCorps.Controls.Add(this.lblActif);
            this.pnlCorps.Controls.Add(this.chkActif);
            this.pnlCorps.Controls.Add(this.lblDesc);
            this.pnlCorps.Controls.Add(this.txtDesc);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblCode.Location = new System.Drawing.Point(28, 20);
            this.lblCode.Text = "Code *";
            this.lblCode.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtCode.Location = new System.Drawing.Point(28, 44);
            this.txtCode.MaxLength = 15;
            this.txtCode.Size = new System.Drawing.Size(310, 29);
            this.txtCode.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblLibelle.Location = new System.Drawing.Point(354, 20);
            this.lblLibelle.Text = "Libellé du compte *";
            this.lblLibelle.TabIndex = 2;
            // 
            // txtLibelle
            // 
            this.txtLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtLibelle.Location = new System.Drawing.Point(354, 44);
            this.txtLibelle.MaxLength = 100;
            this.txtLibelle.Size = new System.Drawing.Size(310, 29);
            this.txtLibelle.TabIndex = 3;
            // 
            // lblype
            // 
            this.lblype.AutoSize = true;
            this.lblype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblype.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblype.Location = new System.Drawing.Point(28, 87);
            this.lblype.Text = "Type de compte *";
            this.lblype.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(28, 111);
            this.cbType.Size = new System.Drawing.Size(310, 29);
            this.cbType.TabIndex = 5;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblDevise.Location = new System.Drawing.Point(354, 87);
            this.lblDevise.Text = "Devise *";
            this.lblDevise.TabIndex = 6;
            // 
            // txtDevise
            // 
            this.txtDevise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDevise.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevise.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtDevise.Location = new System.Drawing.Point(354, 111);
            this.txtDevise.MaxLength = 10;
            this.txtDevise.Size = new System.Drawing.Size(310, 29);
            this.txtDevise.Text = "FCFA";
            this.txtDevise.TabIndex = 7;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblSolde.Location = new System.Drawing.Point(28, 154);
            this.lblSolde.Text = "Solde initial";
            this.lblSolde.TabIndex = 8;
            // 
            // nudSolde
            // 
            this.nudSolde.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSolde.Location = new System.Drawing.Point(28, 178);
            this.nudSolde.Size = new System.Drawing.Size(310, 29);
            this.nudSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSolde.ThousandsSeparator = true;
            this.nudSolde.TabIndex = 9;
            // 
            // lblOuverture
            // 
            this.lblOuverture.AutoSize = true;
            this.lblOuverture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuverture.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblOuverture.Location = new System.Drawing.Point(354, 154);
            this.lblOuverture.Text = "Date d'ouverture";
            this.lblOuverture.TabIndex = 10;
            // 
            // dtOuverture
            // 
            this.dtOuverture.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOuverture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOuverture.Location = new System.Drawing.Point(354, 178);
            this.dtOuverture.Size = new System.Drawing.Size(310, 29);
            this.dtOuverture.TabIndex = 11;
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
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblDesc.Location = new System.Drawing.Point(28, 288);
            this.lblDesc.Text = "Description";
            this.lblDesc.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtDesc.Location = new System.Drawing.Point(28, 312);
            this.txtDesc.MaxLength = 255;
            this.txtDesc.Multiline = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(636, 70);
            this.txtDesc.TabIndex = 15;
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
            // FrmCompteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnEnregistrer;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(700, 568);
            this.Controls.Add(this.pnlCorps);
            this.Controls.Add(this.pnlPied);
            this.Controls.Add(this.pnlEntete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompteDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mini Trésorerie";
            ((System.ComponentModel.ISupportInitialize)(this.nudSolde)).EndInit();
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
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblype;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.TextBox txtDevise;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.NumericUpDown nudSolde;
        private System.Windows.Forms.Label lblOuverture;
        private System.Windows.Forms.DateTimePicker dtOuverture;
        private System.Windows.Forms.Label lblActif;
        private System.Windows.Forms.CheckBox chkActif;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
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
