namespace MiniTresorerie.UInterface
{
    partial class FrmTypeCompteDetail
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
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
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
            this.pnlCorps.Size = new System.Drawing.Size(700, 103);
            this.pnlCorps.TabIndex = 0;
            this.pnlCorps.Controls.Add(this.lblLibelle);
            this.pnlCorps.Controls.Add(this.txtLibelle);
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblLibelle.Location = new System.Drawing.Point(28, 20);
            this.lblLibelle.Text = "Libellé *";
            this.lblLibelle.TabIndex = 0;
            // 
            // txtLibelle
            // 
            this.txtLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtLibelle.Location = new System.Drawing.Point(28, 44);
            this.txtLibelle.MaxLength = 60;
            this.txtLibelle.Size = new System.Drawing.Size(636, 29);
            this.txtLibelle.TabIndex = 1;
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
            // FrmTypeCompteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnEnregistrer;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(700, 259);
            this.Controls.Add(this.pnlCorps);
            this.Controls.Add(this.pnlPied);
            this.Controls.Add(this.pnlEntete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTypeCompteDetail";
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
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
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
