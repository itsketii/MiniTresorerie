namespace MiniTresorerie.UInterface
{
    partial class FrmMotDePasse
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
            this.lblAncien = new System.Windows.Forms.Label();
            this.txtAncien = new System.Windows.Forms.TextBox();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
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
            this.pnlCorps.Size = new System.Drawing.Size(700, 170);
            this.pnlCorps.TabIndex = 0;
            this.pnlCorps.Controls.Add(this.lblAncien);
            this.pnlCorps.Controls.Add(this.txtAncien);
            this.pnlCorps.Controls.Add(this.lblNouveau);
            this.pnlCorps.Controls.Add(this.txtNouveau);
            this.pnlCorps.Controls.Add(this.lblConfirm);
            this.pnlCorps.Controls.Add(this.txtConfirm);
            // 
            // lblAncien
            // 
            this.lblAncien.AutoSize = true;
            this.lblAncien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncien.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblAncien.Location = new System.Drawing.Point(28, 20);
            this.lblAncien.Text = "Mot de passe actuel *";
            this.lblAncien.TabIndex = 0;
            // 
            // txtAncien
            // 
            this.txtAncien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAncien.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncien.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtAncien.Location = new System.Drawing.Point(28, 44);
            this.txtAncien.MaxLength = 100;
            this.txtAncien.Size = new System.Drawing.Size(636, 29);
            this.txtAncien.UseSystemPasswordChar = true;
            this.txtAncien.TabIndex = 1;
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouveau.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblNouveau.Location = new System.Drawing.Point(28, 87);
            this.lblNouveau.Text = "Nouveau mot de passe *";
            this.lblNouveau.TabIndex = 2;
            // 
            // txtNouveau
            // 
            this.txtNouveau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNouveau.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveau.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtNouveau.Location = new System.Drawing.Point(28, 111);
            this.txtNouveau.MaxLength = 100;
            this.txtNouveau.Size = new System.Drawing.Size(310, 29);
            this.txtNouveau.UseSystemPasswordChar = true;
            this.txtNouveau.TabIndex = 3;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblConfirm.Location = new System.Drawing.Point(354, 87);
            this.lblConfirm.Text = "Confirmation *";
            this.lblConfirm.TabIndex = 4;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtConfirm.Location = new System.Drawing.Point(354, 111);
            this.txtConfirm.MaxLength = 100;
            this.txtConfirm.Size = new System.Drawing.Size(310, 29);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TabIndex = 5;
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
            this.lblSousTitre.Text = "Choisissez un mot de passe d'au moins 6 caractères.";
            this.lblSousTitre.TabIndex = 2;
            // 
            // pnlLigneOr
            // 
            this.pnlLigneOr.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.pnlLigneOr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLigneOr.Size = new System.Drawing.Size(700, 3);
            this.pnlLigneOr.TabIndex = 3;
            // 
            // FrmMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AcceptButton = this.btnEnregistrer;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(700, 326);
            this.Controls.Add(this.pnlCorps);
            this.Controls.Add(this.pnlPied);
            this.Controls.Add(this.pnlEntete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMotDePasse";
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
        private System.Windows.Forms.Label lblAncien;
        private System.Windows.Forms.TextBox txtAncien;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
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
