namespace MiniTresorerie.UInterface
{
    partial class FrmTableauDeBord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKTreso = new System.Windows.Forms.Panel();
            this.lblKTresoValeur = new System.Windows.Forms.Label();
            this.lblKTresoTitre = new System.Windows.Forms.Label();
            this.lblKTresoDetail = new System.Windows.Forms.Label();
            this.pnlKTresoAccent = new System.Windows.Forms.Panel();
            this.pnlKRec = new System.Windows.Forms.Panel();
            this.lblKRecValeur = new System.Windows.Forms.Label();
            this.lblKRecTitre = new System.Windows.Forms.Label();
            this.lblKRecDetail = new System.Windows.Forms.Label();
            this.pnlKRecAccent = new System.Windows.Forms.Panel();
            this.pnlKDep = new System.Windows.Forms.Panel();
            this.lblKDepValeur = new System.Windows.Forms.Label();
            this.lblKDepTitre = new System.Windows.Forms.Label();
            this.lblKDepDetail = new System.Windows.Forms.Label();
            this.pnlKDepAccent = new System.Windows.Forms.Panel();
            this.pnlKRes = new System.Windows.Forms.Panel();
            this.lblKResValeur = new System.Windows.Forms.Label();
            this.lblKResTitre = new System.Windows.Forms.Label();
            this.lblKResDetail = new System.Windows.Forms.Label();
            this.pnlKResAccent = new System.Windows.Forms.Panel();
            this.pnlBarres = new System.Windows.Forms.Panel();
            this.gBarres = new MiniTresorerie.UInterface.Composants.GraphiqueBarres();
            this.lblTitreBarres = new System.Windows.Forms.Label();
            this.pnlDonut = new System.Windows.Forms.Panel();
            this.gDonut = new MiniTresorerie.UInterface.Composants.GraphiqueDonut();
            this.lblTitreDonut = new System.Windows.Forms.Label();
            this.pnlOps = new System.Windows.Forms.Panel();
            this.dgvOps = new System.Windows.Forms.DataGridView();
            this.col_dgvOps_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvOps_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvOps_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvOps_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitreOps = new System.Windows.Forms.Label();
            this.pnlCentres = new System.Windows.Forms.Panel();
            this.gCentres = new MiniTresorerie.UInterface.Composants.GraphiqueBarresH();
            this.lblTitreCentres = new System.Windows.Forms.Label();
            this.pnlBarre = new System.Windows.Forms.Panel();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.flowFiltres = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOps)).BeginInit();
            this.tlp.SuspendLayout();
            this.pnlKTreso.SuspendLayout();
            this.pnlKRec.SuspendLayout();
            this.pnlKDep.SuspendLayout();
            this.pnlKRes.SuspendLayout();
            this.pnlBarres.SuspendLayout();
            this.pnlDonut.SuspendLayout();
            this.pnlOps.SuspendLayout();
            this.pnlCentres.SuspendLayout();
            this.pnlBarre.SuspendLayout();
            this.flowFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.Transparent;
            this.tlp.ColumnCount = 4;
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.RowCount = 3;
            this.tlp.Size = new System.Drawing.Size(1100, 648);
            this.tlp.TabIndex = 0;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlp.Controls.Add(this.pnlKTreso, 0, 0);
            this.tlp.Controls.Add(this.pnlKRec, 1, 0);
            this.tlp.Controls.Add(this.pnlKDep, 2, 0);
            this.tlp.Controls.Add(this.pnlKRes, 3, 0);
            this.tlp.Controls.Add(this.pnlBarres, 0, 1);
            this.tlp.SetColumnSpan(this.pnlBarres, 3);
            this.tlp.Controls.Add(this.pnlDonut, 3, 1);
            this.tlp.Controls.Add(this.pnlOps, 0, 2);
            this.tlp.SetColumnSpan(this.pnlOps, 2);
            this.tlp.Controls.Add(this.pnlCentres, 2, 2);
            this.tlp.SetColumnSpan(this.pnlCentres, 2);
            // 
            // pnlKTreso
            // 
            this.pnlKTreso.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKTreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKTreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKTreso.Size = new System.Drawing.Size(250, 118);
            this.pnlKTreso.TabIndex = 0;
            this.pnlKTreso.Controls.Add(this.lblKTresoValeur);
            this.pnlKTreso.Controls.Add(this.lblKTresoTitre);
            this.pnlKTreso.Controls.Add(this.lblKTresoDetail);
            this.pnlKTreso.Controls.Add(this.pnlKTresoAccent);
            // 
            // lblKTresoValeur
            // 
            this.lblKTresoValeur.AutoSize = true;
            this.lblKTresoValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKTresoValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTresoValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKTresoValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKTresoValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKTresoValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKTresoValeur.Text = "0";
            this.lblKTresoValeur.TabIndex = 0;
            // 
            // lblKTresoTitre
            // 
            this.lblKTresoTitre.AutoSize = true;
            this.lblKTresoTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKTresoTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTresoTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKTresoTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKTresoTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKTresoTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKTresoTitre.Text = "Trésorerie totale";
            this.lblKTresoTitre.TabIndex = 1;
            // 
            // lblKTresoDetail
            // 
            this.lblKTresoDetail.AutoSize = true;
            this.lblKTresoDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKTresoDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTresoDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKTresoDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKTresoDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKTresoDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKTresoDetail.Text = "";
            this.lblKTresoDetail.TabIndex = 2;
            // 
            // pnlKTresoAccent
            // 
            this.pnlKTresoAccent.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.pnlKTresoAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKTresoAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKTresoAccent.TabIndex = 3;
            // 
            // pnlKRec
            // 
            this.pnlKRec.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKRec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKRec.Size = new System.Drawing.Size(250, 118);
            this.pnlKRec.TabIndex = 1;
            this.pnlKRec.Controls.Add(this.lblKRecValeur);
            this.pnlKRec.Controls.Add(this.lblKRecTitre);
            this.pnlKRec.Controls.Add(this.lblKRecDetail);
            this.pnlKRec.Controls.Add(this.pnlKRecAccent);
            // 
            // lblKRecValeur
            // 
            this.lblKRecValeur.AutoSize = true;
            this.lblKRecValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKRecValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRecValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKRecValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKRecValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKRecValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKRecValeur.Text = "0";
            this.lblKRecValeur.TabIndex = 0;
            // 
            // lblKRecTitre
            // 
            this.lblKRecTitre.AutoSize = true;
            this.lblKRecTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKRecTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRecTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKRecTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKRecTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKRecTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKRecTitre.Text = "Recettes de la période";
            this.lblKRecTitre.TabIndex = 1;
            // 
            // lblKRecDetail
            // 
            this.lblKRecDetail.AutoSize = true;
            this.lblKRecDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKRecDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRecDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKRecDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKRecDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKRecDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKRecDetail.Text = "";
            this.lblKRecDetail.TabIndex = 2;
            // 
            // pnlKRecAccent
            // 
            this.pnlKRecAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlKRecAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKRecAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKRecAccent.TabIndex = 3;
            // 
            // pnlKDep
            // 
            this.pnlKDep.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKDep.Size = new System.Drawing.Size(250, 118);
            this.pnlKDep.TabIndex = 2;
            this.pnlKDep.Controls.Add(this.lblKDepValeur);
            this.pnlKDep.Controls.Add(this.lblKDepTitre);
            this.pnlKDep.Controls.Add(this.lblKDepDetail);
            this.pnlKDep.Controls.Add(this.pnlKDepAccent);
            // 
            // lblKDepValeur
            // 
            this.lblKDepValeur.AutoSize = true;
            this.lblKDepValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKDepValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDepValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKDepValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKDepValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKDepValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKDepValeur.Text = "0";
            this.lblKDepValeur.TabIndex = 0;
            // 
            // lblKDepTitre
            // 
            this.lblKDepTitre.AutoSize = true;
            this.lblKDepTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKDepTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDepTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKDepTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKDepTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKDepTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKDepTitre.Text = "Dépenses de la période";
            this.lblKDepTitre.TabIndex = 1;
            // 
            // lblKDepDetail
            // 
            this.lblKDepDetail.AutoSize = true;
            this.lblKDepDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKDepDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDepDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKDepDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKDepDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKDepDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKDepDetail.Text = "";
            this.lblKDepDetail.TabIndex = 2;
            // 
            // pnlKDepAccent
            // 
            this.pnlKDepAccent.BackColor = System.Drawing.Color.FromArgb(176, 140, 28);
            this.pnlKDepAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKDepAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKDepAccent.TabIndex = 3;
            // 
            // pnlKRes
            // 
            this.pnlKRes.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKRes.Size = new System.Drawing.Size(250, 118);
            this.pnlKRes.TabIndex = 3;
            this.pnlKRes.Controls.Add(this.lblKResValeur);
            this.pnlKRes.Controls.Add(this.lblKResTitre);
            this.pnlKRes.Controls.Add(this.lblKResDetail);
            this.pnlKRes.Controls.Add(this.pnlKResAccent);
            // 
            // lblKResValeur
            // 
            this.lblKResValeur.AutoSize = true;
            this.lblKResValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKResValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKResValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKResValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKResValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKResValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKResValeur.Text = "0";
            this.lblKResValeur.TabIndex = 0;
            // 
            // lblKResTitre
            // 
            this.lblKResTitre.AutoSize = true;
            this.lblKResTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKResTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKResTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKResTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKResTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKResTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKResTitre.Text = "Résultat net";
            this.lblKResTitre.TabIndex = 1;
            // 
            // lblKResDetail
            // 
            this.lblKResDetail.AutoSize = true;
            this.lblKResDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKResDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKResDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKResDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKResDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKResDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKResDetail.Text = "";
            this.lblKResDetail.TabIndex = 2;
            // 
            // pnlKResAccent
            // 
            this.pnlKResAccent.BackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.pnlKResAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKResAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKResAccent.TabIndex = 3;
            // 
            // pnlBarres
            // 
            this.pnlBarres.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlBarres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBarres.Padding = new System.Windows.Forms.Padding(14, 8, 14, 12);
            this.pnlBarres.Size = new System.Drawing.Size(300, 300);
            this.pnlBarres.TabIndex = 4;
            this.pnlBarres.Controls.Add(this.gBarres);
            this.pnlBarres.Controls.Add(this.lblTitreBarres);
            // 
            // gBarres
            // 
            this.gBarres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBarres.Size = new System.Drawing.Size(100, 100);
            this.gBarres.TabIndex = 0;
            // 
            // lblTitreBarres
            // 
            this.lblTitreBarres.AutoSize = true;
            this.lblTitreBarres.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreBarres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreBarres.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblTitreBarres.Size = new System.Drawing.Size(100, 34);
            this.lblTitreBarres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitreBarres.Text = "Évolution mensuelle — recettes et dépenses";
            this.lblTitreBarres.TabIndex = 1;
            // 
            // pnlDonut
            // 
            this.pnlDonut.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlDonut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDonut.Padding = new System.Windows.Forms.Padding(14, 8, 14, 12);
            this.pnlDonut.Size = new System.Drawing.Size(300, 300);
            this.pnlDonut.TabIndex = 5;
            this.pnlDonut.Controls.Add(this.gDonut);
            this.pnlDonut.Controls.Add(this.lblTitreDonut);
            // 
            // gDonut
            // 
            this.gDonut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDonut.LibelleCentre = "Dépenses";
            this.gDonut.Size = new System.Drawing.Size(100, 100);
            this.gDonut.TabIndex = 0;
            // 
            // lblTitreDonut
            // 
            this.lblTitreDonut.AutoSize = true;
            this.lblTitreDonut.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreDonut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreDonut.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblTitreDonut.Size = new System.Drawing.Size(100, 34);
            this.lblTitreDonut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitreDonut.Text = "Dépenses par catégorie";
            this.lblTitreDonut.TabIndex = 1;
            // 
            // pnlOps
            // 
            this.pnlOps.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOps.Padding = new System.Windows.Forms.Padding(14, 8, 14, 12);
            this.pnlOps.Size = new System.Drawing.Size(300, 300);
            this.pnlOps.TabIndex = 6;
            this.pnlOps.Controls.Add(this.dgvOps);
            this.pnlOps.Controls.Add(this.lblTitreOps);
            // 
            // dgvOps
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(249, 252, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            this.dgvOps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOps.AllowUserToAddRows = false;
            this.dgvOps.AllowUserToDeleteRows = false;
            this.dgvOps.AllowUserToResizeRows = false;
            this.dgvOps.AutoGenerateColumns = false;
            this.dgvOps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOps.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvOps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOps.ColumnHeadersHeight = 38;
            this.dgvOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvOps_0,
            this.col_dgvOps_1,
            this.col_dgvOps_2,
            this.col_dgvOps_3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOps.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOps.EnableHeadersVisualStyles = false;
            this.dgvOps.GridColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.dgvOps.MultiSelect = false;
            this.dgvOps.ReadOnly = true;
            this.dgvOps.RowHeadersVisible = false;
            this.dgvOps.RowHeadersWidth = 51;
            this.dgvOps.RowTemplate.Height = 36;
            this.dgvOps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOps.Size = new System.Drawing.Size(400, 300);
            this.dgvOps.TabIndex = 0;
            // 
            // col_dgvOps_0
            // 
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.col_dgvOps_0.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgvOps_0.DataPropertyName = "MvtDate";
            this.col_dgvOps_0.FillWeight = 90F;
            this.col_dgvOps_0.HeaderText = "Date";
            this.col_dgvOps_0.MinimumWidth = 6;
            this.col_dgvOps_0.Name = "colMvtDate_dgvOps";
            this.col_dgvOps_0.ReadOnly = true;
            this.col_dgvOps_0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgvOps_1
            // 
            this.col_dgvOps_1.DataPropertyName = "MvtLibelle";
            this.col_dgvOps_1.FillWeight = 260F;
            this.col_dgvOps_1.HeaderText = "Libellé";
            this.col_dgvOps_1.MinimumWidth = 6;
            this.col_dgvOps_1.Name = "colMvtLibelle_dgvOps";
            this.col_dgvOps_1.ReadOnly = true;
            this.col_dgvOps_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgvOps_2
            // 
            this.col_dgvOps_2.DataPropertyName = "CatLibelle";
            this.col_dgvOps_2.FillWeight = 150F;
            this.col_dgvOps_2.HeaderText = "Catégorie";
            this.col_dgvOps_2.MinimumWidth = 6;
            this.col_dgvOps_2.Name = "colCatLibelle_dgvOps";
            this.col_dgvOps_2.ReadOnly = true;
            this.col_dgvOps_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgvOps_3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "+#,##0;-#,##0";
            this.col_dgvOps_3.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgvOps_3.DataPropertyName = "MontantSigne";
            this.col_dgvOps_3.FillWeight = 130F;
            this.col_dgvOps_3.HeaderText = "Montant";
            this.col_dgvOps_3.MinimumWidth = 6;
            this.col_dgvOps_3.Name = "colMontantSigne_dgvOps";
            this.col_dgvOps_3.ReadOnly = true;
            this.col_dgvOps_3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvOps.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOps_CellFormatting);
            // 
            // lblTitreOps
            // 
            this.lblTitreOps.AutoSize = true;
            this.lblTitreOps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreOps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreOps.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblTitreOps.Size = new System.Drawing.Size(100, 34);
            this.lblTitreOps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitreOps.Text = "Dernières opérations";
            this.lblTitreOps.TabIndex = 1;
            // 
            // pnlCentres
            // 
            this.pnlCentres.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCentres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCentres.Padding = new System.Windows.Forms.Padding(14, 8, 14, 12);
            this.pnlCentres.Size = new System.Drawing.Size(300, 300);
            this.pnlCentres.TabIndex = 7;
            this.pnlCentres.Controls.Add(this.gCentres);
            this.pnlCentres.Controls.Add(this.lblTitreCentres);
            // 
            // gCentres
            // 
            this.gCentres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCentres.Size = new System.Drawing.Size(100, 100);
            this.gCentres.TabIndex = 0;
            // 
            // lblTitreCentres
            // 
            this.lblTitreCentres.AutoSize = true;
            this.lblTitreCentres.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreCentres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCentres.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblTitreCentres.Size = new System.Drawing.Size(100, 34);
            this.lblTitreCentres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitreCentres.Text = "Dépenses par centre d'imputation";
            this.lblTitreCentres.TabIndex = 1;
            // 
            // pnlBarre
            // 
            this.pnlBarre.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarre.Size = new System.Drawing.Size(1100, 52);
            this.pnlBarre.TabIndex = 1;
            this.pnlBarre.Controls.Add(this.lblPeriode);
            this.pnlBarre.Controls.Add(this.flowFiltres);
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriode.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.lblPeriode.Location = new System.Drawing.Point(0, 10);
            this.lblPeriode.Text = "Exercice";
            this.lblPeriode.TabIndex = 0;
            // 
            // flowFiltres
            // 
            this.flowFiltres.AutoSize = true;
            this.flowFiltres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowFiltres.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowFiltres.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowFiltres.Size = new System.Drawing.Size(420, 52);
            this.flowFiltres.WrapContents = false;
            this.flowFiltres.TabIndex = 1;
            this.flowFiltres.Controls.Add(this.lblAnnee);
            this.flowFiltres.Controls.Add(this.cbAnnee);
            this.flowFiltres.Controls.Add(this.lblMois);
            this.flowFiltres.Controls.Add(this.cbMois);
            this.flowFiltres.Controls.Add(this.btnActualiser);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblAnnee.Location = new System.Drawing.Point(0, 0);
            this.lblAnnee.Text = "Année";
            this.lblAnnee.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblAnnee.TabIndex = 0;
            // 
            // cbAnnee
            // 
            this.cbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(0, 0);
            this.cbAnnee.Margin = new System.Windows.Forms.Padding(0, 5, 14, 0);
            this.cbAnnee.Size = new System.Drawing.Size(90, 29);
            this.cbAnnee.TabIndex = 1;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMois.Location = new System.Drawing.Point(0, 0);
            this.lblMois.Text = "Mois";
            this.lblMois.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblMois.TabIndex = 2;
            // 
            // cbMois
            // 
            this.cbMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMois.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Location = new System.Drawing.Point(0, 0);
            this.cbMois.Margin = new System.Windows.Forms.Padding(0, 5, 14, 0);
            this.cbMois.Size = new System.Drawing.Size(170, 29);
            this.cbMois.TabIndex = 3;
            this.cbMois.Items.AddRange(new object[] {
            "Toute l'année",
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbMois.SelectedIndexChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnActualiser.Location = new System.Drawing.Point(0, 0);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnActualiser.Size = new System.Drawing.Size(110, 36);
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnActualiser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnActualiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.pnlBarre);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOps)).EndInit();
            this.flowFiltres.ResumeLayout(false);
            this.flowFiltres.PerformLayout();
            this.pnlBarre.ResumeLayout(false);
            this.pnlBarre.PerformLayout();
            this.pnlCentres.ResumeLayout(false);
            this.pnlCentres.PerformLayout();
            this.pnlOps.ResumeLayout(false);
            this.pnlOps.PerformLayout();
            this.pnlDonut.ResumeLayout(false);
            this.pnlDonut.PerformLayout();
            this.pnlBarres.ResumeLayout(false);
            this.pnlBarres.PerformLayout();
            this.pnlKRes.ResumeLayout(false);
            this.pnlKRes.PerformLayout();
            this.pnlKDep.ResumeLayout(false);
            this.pnlKDep.PerformLayout();
            this.pnlKRec.ResumeLayout(false);
            this.pnlKRec.PerformLayout();
            this.pnlKTreso.ResumeLayout(false);
            this.pnlKTreso.PerformLayout();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Panel pnlKTreso;
        private System.Windows.Forms.Label lblKTresoValeur;
        private System.Windows.Forms.Label lblKTresoTitre;
        private System.Windows.Forms.Label lblKTresoDetail;
        private System.Windows.Forms.Panel pnlKTresoAccent;
        private System.Windows.Forms.Panel pnlKRec;
        private System.Windows.Forms.Label lblKRecValeur;
        private System.Windows.Forms.Label lblKRecTitre;
        private System.Windows.Forms.Label lblKRecDetail;
        private System.Windows.Forms.Panel pnlKRecAccent;
        private System.Windows.Forms.Panel pnlKDep;
        private System.Windows.Forms.Label lblKDepValeur;
        private System.Windows.Forms.Label lblKDepTitre;
        private System.Windows.Forms.Label lblKDepDetail;
        private System.Windows.Forms.Panel pnlKDepAccent;
        private System.Windows.Forms.Panel pnlKRes;
        private System.Windows.Forms.Label lblKResValeur;
        private System.Windows.Forms.Label lblKResTitre;
        private System.Windows.Forms.Label lblKResDetail;
        private System.Windows.Forms.Panel pnlKResAccent;
        private System.Windows.Forms.Panel pnlBarres;
        private MiniTresorerie.UInterface.Composants.GraphiqueBarres gBarres;
        private System.Windows.Forms.Label lblTitreBarres;
        private System.Windows.Forms.Panel pnlDonut;
        private MiniTresorerie.UInterface.Composants.GraphiqueDonut gDonut;
        private System.Windows.Forms.Label lblTitreDonut;
        private System.Windows.Forms.Panel pnlOps;
        private System.Windows.Forms.DataGridView dgvOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOps_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOps_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOps_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvOps_3;
        private System.Windows.Forms.Label lblTitreOps;
        private System.Windows.Forms.Panel pnlCentres;
        private MiniTresorerie.UInterface.Composants.GraphiqueBarresH gCentres;
        private System.Windows.Forms.Label lblTitreCentres;
        private System.Windows.Forms.Panel pnlBarre;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.FlowLayoutPanel flowFiltres;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.ComboBox cbAnnee;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.Button btnActualiser;
    }
}
