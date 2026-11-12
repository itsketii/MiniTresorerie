namespace MiniTresorerie.UInterface
{
    partial class FrmMouvementDetail
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
            this.lblype = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblompte = new System.Windows.Forms.Label();
            this.cbCompte = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            this.lblategorie = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblentre = new System.Windows.Forms.Label();
            this.cbCentre = new System.Windows.Forms.ComboBox();
            this.lblode = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.lblTiers = new System.Windows.Forms.Label();
            this.txtTiers = new System.Windows.Forms.TextBox();
            this.lblPiece = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlPied = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pnlEntete = new MiniTresorerie.UInterface.Composants.PanelDegrade();
            this.logo = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlLigneOr = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
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
            this.pnlCorps.Size = new System.Drawing.Size(700, 492);
            this.pnlCorps.TabIndex = 0;
            this.pnlCorps.Controls.Add(this.lblype);
            this.pnlCorps.Controls.Add(this.cbType);
            this.pnlCorps.Controls.Add(this.lblDate);
            this.pnlCorps.Controls.Add(this.dtDate);
            this.pnlCorps.Controls.Add(this.lblompte);
            this.pnlCorps.Controls.Add(this.cbCompte);
            this.pnlCorps.Controls.Add(this.lblMontant);
            this.pnlCorps.Controls.Add(this.nudMontant);
            this.pnlCorps.Controls.Add(this.lblategorie);
            this.pnlCorps.Controls.Add(this.cbCategorie);
            this.pnlCorps.Controls.Add(this.lblentre);
            this.pnlCorps.Controls.Add(this.cbCentre);
            this.pnlCorps.Controls.Add(this.lblode);
            this.pnlCorps.Controls.Add(this.cbMode);
            this.pnlCorps.Controls.Add(this.lblTiers);
            this.pnlCorps.Controls.Add(this.txtTiers);
            this.pnlCorps.Controls.Add(this.lblPiece);
            this.pnlCorps.Controls.Add(this.txtPiece);
            this.pnlCorps.Controls.Add(this.lblRef);
            this.pnlCorps.Controls.Add(this.txtRef);
            this.pnlCorps.Controls.Add(this.lblLibelle);
            this.pnlCorps.Controls.Add(this.txtLibelle);
            this.pnlCorps.Controls.Add(this.lblNote);
            // 
            // lblype
            // 
            this.lblype.AutoSize = true;
            this.lblype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblype.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblype.Location = new System.Drawing.Point(28, 20);
            this.lblype.Text = "Type d'opération *";
            this.lblype.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(28, 44);
            this.cbType.Size = new System.Drawing.Size(310, 29);
            this.cbType.TabIndex = 1;
            this.cbType.Items.AddRange(new object[] {
            "Recette (entrée d'argent)",
            "Dépense (sortie d'argent)"});
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblDate.Location = new System.Drawing.Point(354, 20);
            this.lblDate.Text = "Date de l'opération";
            this.lblDate.TabIndex = 2;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(354, 44);
            this.dtDate.Size = new System.Drawing.Size(310, 29);
            this.dtDate.TabIndex = 3;
            // 
            // lblompte
            // 
            this.lblompte.AutoSize = true;
            this.lblompte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblompte.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblompte.Location = new System.Drawing.Point(28, 87);
            this.lblompte.Text = "Compte de trésorerie *";
            this.lblompte.TabIndex = 4;
            // 
            // cbCompte
            // 
            this.cbCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompte.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.Location = new System.Drawing.Point(28, 111);
            this.cbCompte.Size = new System.Drawing.Size(310, 29);
            this.cbCompte.TabIndex = 5;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblMontant.Location = new System.Drawing.Point(354, 87);
            this.lblMontant.Text = "Montant (FCFA) *";
            this.lblMontant.TabIndex = 6;
            // 
            // nudMontant
            // 
            this.nudMontant.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontant.Location = new System.Drawing.Point(354, 111);
            this.nudMontant.Size = new System.Drawing.Size(310, 29);
            this.nudMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMontant.ThousandsSeparator = true;
            this.nudMontant.TabIndex = 7;
            this.nudMontant.ValueChanged += new System.EventHandler(this.nudMontant_ValueChanged);
            // 
            // lblategorie
            // 
            this.lblategorie.AutoSize = true;
            this.lblategorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblategorie.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblategorie.Location = new System.Drawing.Point(28, 154);
            this.lblategorie.Text = "Catégorie *";
            this.lblategorie.TabIndex = 8;
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(28, 178);
            this.cbCategorie.Size = new System.Drawing.Size(310, 29);
            this.cbCategorie.TabIndex = 9;
            // 
            // lblentre
            // 
            this.lblentre.AutoSize = true;
            this.lblentre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentre.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblentre.Location = new System.Drawing.Point(354, 154);
            this.lblentre.Text = "Centre d'imputation";
            this.lblentre.TabIndex = 10;
            // 
            // cbCentre
            // 
            this.cbCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCentre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentre.FormattingEnabled = true;
            this.cbCentre.Location = new System.Drawing.Point(354, 178);
            this.cbCentre.Size = new System.Drawing.Size(310, 29);
            this.cbCentre.TabIndex = 11;
            // 
            // lblode
            // 
            this.lblode.AutoSize = true;
            this.lblode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblode.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblode.Location = new System.Drawing.Point(28, 221);
            this.lblode.Text = "Mode de paiement *";
            this.lblode.TabIndex = 12;
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(28, 245);
            this.cbMode.Size = new System.Drawing.Size(310, 29);
            this.cbMode.TabIndex = 13;
            // 
            // lblTiers
            // 
            this.lblTiers.AutoSize = true;
            this.lblTiers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiers.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblTiers.Location = new System.Drawing.Point(354, 221);
            this.lblTiers.Text = "Tiers (client / fournisseur)";
            this.lblTiers.TabIndex = 14;
            // 
            // txtTiers
            // 
            this.txtTiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiers.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiers.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtTiers.Location = new System.Drawing.Point(354, 245);
            this.txtTiers.MaxLength = 100;
            this.txtTiers.Size = new System.Drawing.Size(310, 29);
            this.txtTiers.TabIndex = 15;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblPiece.Location = new System.Drawing.Point(28, 288);
            this.lblPiece.Text = "Pièce justificative";
            this.lblPiece.TabIndex = 16;
            // 
            // txtPiece
            // 
            this.txtPiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPiece.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiece.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtPiece.Location = new System.Drawing.Point(28, 312);
            this.txtPiece.MaxLength = 60;
            this.txtPiece.Size = new System.Drawing.Size(310, 29);
            this.txtPiece.TabIndex = 17;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblRef.Location = new System.Drawing.Point(354, 288);
            this.lblRef.Text = "Référence";
            this.lblRef.TabIndex = 18;
            // 
            // txtRef
            // 
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRef.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtRef.Location = new System.Drawing.Point(354, 312);
            this.txtRef.ReadOnly = true;
            this.txtRef.Size = new System.Drawing.Size(310, 29);
            this.txtRef.Text = "(générée à l'enregistrement)";
            this.txtRef.TabIndex = 19;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblLibelle.Location = new System.Drawing.Point(28, 355);
            this.lblLibelle.Text = "Libellé *";
            this.lblLibelle.TabIndex = 20;
            // 
            // txtLibelle
            // 
            this.txtLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtLibelle.Location = new System.Drawing.Point(28, 379);
            this.txtLibelle.MaxLength = 150;
            this.txtLibelle.Size = new System.Drawing.Size(636, 29);
            this.txtLibelle.TabIndex = 21;
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNote.Location = new System.Drawing.Point(28, 418);
            this.lblNote.Size = new System.Drawing.Size(636, 44);
            this.lblNote.Text = "Arrêté à : ";
            this.lblNote.TabIndex = 22;
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
            // FrmMouvementDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnEnregistrer;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(700, 648);
            this.Controls.Add(this.pnlCorps);
            this.Controls.Add(this.pnlPied);
            this.Controls.Add(this.pnlEntete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMouvementDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mini Trésorerie";
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
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
        private System.Windows.Forms.Label lblype;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblompte;
        private System.Windows.Forms.ComboBox cbCompte;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.NumericUpDown nudMontant;
        private System.Windows.Forms.Label lblategorie;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblentre;
        private System.Windows.Forms.ComboBox cbCentre;
        private System.Windows.Forms.Label lblode;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label lblTiers;
        private System.Windows.Forms.TextBox txtTiers;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
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
