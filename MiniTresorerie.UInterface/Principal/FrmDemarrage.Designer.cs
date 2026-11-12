namespace MiniTresorerie.UInterface
{
    partial class FrmDemarrage
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
            this.components = new System.ComponentModel.Container();
            this.pnlFond = new MiniTresorerie.UInterface.Composants.PanneauSplash();
            this.logo = new MiniTresorerie.UInterface.Composants.LogoControl();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.barre = new MiniTresorerie.UInterface.Composants.BarreProgression();
            this.lblEtat = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlFond.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFond
            // 
            this.pnlFond.Angle = 40F;
            this.pnlFond.Debut = System.Drawing.Color.FromArgb(2, 44, 34);
            this.pnlFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFond.Fin = System.Drawing.Color.FromArgb(4, 120, 87);
            this.pnlFond.Size = new System.Drawing.Size(640, 380);
            this.pnlFond.TabIndex = 0;
            this.pnlFond.Controls.Add(this.logo);
            this.pnlFond.Controls.Add(this.lblTitre);
            this.pnlFond.Controls.Add(this.lblSousTitre);
            this.pnlFond.Controls.Add(this.barre);
            this.pnlFond.Controls.Add(this.lblEtat);
            this.pnlFond.Controls.Add(this.lblVersion);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(272, 36);
            this.logo.Size = new System.Drawing.Size(96, 96);
            this.logo.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitre.Location = new System.Drawing.Point(0, 146);
            this.lblTitre.Size = new System.Drawing.Size(640, 54);
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitre.Text = "MINI TRÉSORERIE";
            this.lblTitre.TabIndex = 1;
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblSousTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblSousTitre.Location = new System.Drawing.Point(0, 202);
            this.lblSousTitre.Size = new System.Drawing.Size(640, 30);
            this.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSousTitre.Text = "Gestion de trésorerie et suivi analytique";
            this.lblSousTitre.TabIndex = 2;
            // 
            // barre
            // 
            this.barre.Location = new System.Drawing.Point(120, 290);
            this.barre.Size = new System.Drawing.Size(400, 8);
            this.barre.TabIndex = 3;
            // 
            // lblEtat
            // 
            this.lblEtat.BackColor = System.Drawing.Color.Transparent;
            this.lblEtat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.ForeColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.lblEtat.Location = new System.Drawing.Point(0, 308);
            this.lblEtat.Size = new System.Drawing.Size(640, 28);
            this.lblEtat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEtat.Text = "Initialisation…";
            this.lblEtat.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(170, 200, 190);
            this.lblVersion.Location = new System.Drawing.Point(0, 344);
            this.lblVersion.Size = new System.Drawing.Size(640, 24);
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Text = "Version 1.0  ·  © 2026";
            this.lblVersion.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(2, 44, 34);
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.pnlFond);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDemarrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Trésorerie";
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.pnlFond.ResumeLayout(false);
            this.pnlFond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MiniTresorerie.UInterface.Composants.PanneauSplash pnlFond;
        private MiniTresorerie.UInterface.Composants.LogoControl logo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private MiniTresorerie.UInterface.Composants.BarreProgression barre;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timer1;
    }
}
