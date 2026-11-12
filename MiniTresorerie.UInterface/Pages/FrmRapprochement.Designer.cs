namespace MiniTresorerie.UInterface
{
    partial class FrmRapprochement
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
            this.pnlCarte = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_dgv_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAide = new System.Windows.Forms.Label();
            this.tlpKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKCompta = new System.Windows.Forms.Panel();
            this.lblKComptaValeur = new System.Windows.Forms.Label();
            this.lblKComptaTitre = new System.Windows.Forms.Label();
            this.lblKComptaDetail = new System.Windows.Forms.Label();
            this.pnlKComptaAccent = new System.Windows.Forms.Panel();
            this.pnlKPointe = new System.Windows.Forms.Panel();
            this.lblKPointeValeur = new System.Windows.Forms.Label();
            this.lblKPointeTitre = new System.Windows.Forms.Label();
            this.lblKPointeDetail = new System.Windows.Forms.Label();
            this.pnlKPointeAccent = new System.Windows.Forms.Panel();
            this.pnlKReleve = new System.Windows.Forms.Panel();
            this.lblKReleveValeur = new System.Windows.Forms.Label();
            this.lblKReleveTitre = new System.Windows.Forms.Label();
            this.lblKReleveDetail = new System.Windows.Forms.Label();
            this.pnlKReleveAccent = new System.Windows.Forms.Panel();
            this.pnlKEcart = new System.Windows.Forms.Panel();
            this.lblKEcartValeur = new System.Windows.Forms.Label();
            this.lblKEcartTitre = new System.Windows.Forms.Label();
            this.lblKEcartDetail = new System.Windows.Forms.Label();
            this.pnlKEcartAccent = new System.Windows.Forms.Panel();
            this.flowBarre = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCompte = new System.Windows.Forms.Label();
            this.cbCompte = new System.Windows.Forms.ComboBox();
            this.lblReleve = new System.Windows.Forms.Label();
            this.nudReleve = new System.Windows.Forms.NumericUpDown();
            this.btnPointer = new System.Windows.Forms.Button();
            this.btnDepointer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReleve)).BeginInit();
            this.pnlCarte.SuspendLayout();
            this.tlpKpi.SuspendLayout();
            this.pnlKCompta.SuspendLayout();
            this.pnlKPointe.SuspendLayout();
            this.pnlKReleve.SuspendLayout();
            this.pnlKEcart.SuspendLayout();
            this.flowBarre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCarte
            // 
            this.pnlCarte.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarte.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCarte.Size = new System.Drawing.Size(1100, 400);
            this.pnlCarte.TabIndex = 0;
            this.pnlCarte.Controls.Add(this.dgv);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(249, 252, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 44;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgv_0,
            this.col_dgv_1,
            this.col_dgv_2,
            this.col_dgv_3,
            this.col_dgv_4,
            this.col_dgv_5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.dgv.MultiSelect = true;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(400, 300);
            this.dgv.TabIndex = 0;
            // 
            // col_dgv_0
            // 
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.col_dgv_0.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgv_0.DataPropertyName = "MvtDate";
            this.col_dgv_0.FillWeight = 90F;
            this.col_dgv_0.HeaderText = "Date";
            this.col_dgv_0.MinimumWidth = 6;
            this.col_dgv_0.Name = "colMvtDate_dgv";
            this.col_dgv_0.ReadOnly = true;
            this.col_dgv_0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_1
            // 
            this.col_dgv_1.DataPropertyName = "MvtReference";
            this.col_dgv_1.FillWeight = 130F;
            this.col_dgv_1.HeaderText = "Référence";
            this.col_dgv_1.MinimumWidth = 6;
            this.col_dgv_1.Name = "colMvtReference_dgv";
            this.col_dgv_1.ReadOnly = true;
            this.col_dgv_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_2
            // 
            this.col_dgv_2.DataPropertyName = "MvtLibelle";
            this.col_dgv_2.FillWeight = 280F;
            this.col_dgv_2.HeaderText = "Libellé";
            this.col_dgv_2.MinimumWidth = 6;
            this.col_dgv_2.Name = "colMvtLibelle_dgv";
            this.col_dgv_2.ReadOnly = true;
            this.col_dgv_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_3
            // 
            this.col_dgv_3.DataPropertyName = "MvtTiers";
            this.col_dgv_3.FillWeight = 140F;
            this.col_dgv_3.HeaderText = "Tiers";
            this.col_dgv_3.MinimumWidth = 6;
            this.col_dgv_3.Name = "colMvtTiers_dgv";
            this.col_dgv_3.ReadOnly = true;
            this.col_dgv_3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "+#,##0;-#,##0";
            this.col_dgv_4.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgv_4.DataPropertyName = "MontantSigne";
            this.col_dgv_4.FillWeight = 130F;
            this.col_dgv_4.HeaderText = "Montant (FCFA)";
            this.col_dgv_4.MinimumWidth = 6;
            this.col_dgv_4.Name = "colMontantSigne_dgv";
            this.col_dgv_4.ReadOnly = true;
            this.col_dgv_4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_5
            // 
            this.col_dgv_5.DataPropertyName = "Etat";
            this.col_dgv_5.FillWeight = 100F;
            this.col_dgv_5.HeaderText = "État";
            this.col_dgv_5.MinimumWidth = 6;
            this.col_dgv_5.Name = "colEtat_dgv";
            this.col_dgv_5.ReadOnly = true;
            this.col_dgv_5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // lblAide
            // 
            this.lblAide.AutoSize = true;
            this.lblAide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAide.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAide.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblAide.Size = new System.Drawing.Size(1100, 32);
            this.lblAide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAide.Text = "Sélectionnez une ou plusieurs lignes (Ctrl / Maj) puis « Pointer la sélection ». Un mouvement pointé n'est plus modifiable.";
            this.lblAide.TabIndex = 1;
            // 
            // tlpKpi
            // 
            this.tlpKpi.BackColor = System.Drawing.Color.Transparent;
            this.tlpKpi.ColumnCount = 4;
            this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKpi.RowCount = 1;
            this.tlpKpi.Size = new System.Drawing.Size(1100, 126);
            this.tlpKpi.TabIndex = 2;
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKpi.Controls.Add(this.pnlKCompta, 0, 0);
            this.tlpKpi.Controls.Add(this.pnlKPointe, 1, 0);
            this.tlpKpi.Controls.Add(this.pnlKReleve, 2, 0);
            this.tlpKpi.Controls.Add(this.pnlKEcart, 3, 0);
            // 
            // pnlKCompta
            // 
            this.pnlKCompta.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKCompta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKCompta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKCompta.Size = new System.Drawing.Size(250, 118);
            this.pnlKCompta.TabIndex = 0;
            this.pnlKCompta.Controls.Add(this.lblKComptaValeur);
            this.pnlKCompta.Controls.Add(this.lblKComptaTitre);
            this.pnlKCompta.Controls.Add(this.lblKComptaDetail);
            this.pnlKCompta.Controls.Add(this.pnlKComptaAccent);
            // 
            // lblKComptaValeur
            // 
            this.lblKComptaValeur.AutoSize = true;
            this.lblKComptaValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKComptaValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKComptaValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKComptaValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKComptaValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKComptaValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKComptaValeur.Text = "0";
            this.lblKComptaValeur.TabIndex = 0;
            // 
            // lblKComptaTitre
            // 
            this.lblKComptaTitre.AutoSize = true;
            this.lblKComptaTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKComptaTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKComptaTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKComptaTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKComptaTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKComptaTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKComptaTitre.Text = "Solde comptable";
            this.lblKComptaTitre.TabIndex = 1;
            // 
            // lblKComptaDetail
            // 
            this.lblKComptaDetail.AutoSize = true;
            this.lblKComptaDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKComptaDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKComptaDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKComptaDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKComptaDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKComptaDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKComptaDetail.Text = "";
            this.lblKComptaDetail.TabIndex = 2;
            // 
            // pnlKComptaAccent
            // 
            this.pnlKComptaAccent.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.pnlKComptaAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKComptaAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKComptaAccent.TabIndex = 3;
            // 
            // pnlKPointe
            // 
            this.pnlKPointe.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKPointe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKPointe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKPointe.Size = new System.Drawing.Size(250, 118);
            this.pnlKPointe.TabIndex = 1;
            this.pnlKPointe.Controls.Add(this.lblKPointeValeur);
            this.pnlKPointe.Controls.Add(this.lblKPointeTitre);
            this.pnlKPointe.Controls.Add(this.lblKPointeDetail);
            this.pnlKPointe.Controls.Add(this.pnlKPointeAccent);
            // 
            // lblKPointeValeur
            // 
            this.lblKPointeValeur.AutoSize = true;
            this.lblKPointeValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKPointeValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPointeValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKPointeValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKPointeValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKPointeValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKPointeValeur.Text = "0";
            this.lblKPointeValeur.TabIndex = 0;
            // 
            // lblKPointeTitre
            // 
            this.lblKPointeTitre.AutoSize = true;
            this.lblKPointeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKPointeTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPointeTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKPointeTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKPointeTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKPointeTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKPointeTitre.Text = "Solde pointé";
            this.lblKPointeTitre.TabIndex = 1;
            // 
            // lblKPointeDetail
            // 
            this.lblKPointeDetail.AutoSize = true;
            this.lblKPointeDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKPointeDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPointeDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKPointeDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKPointeDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKPointeDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKPointeDetail.Text = "";
            this.lblKPointeDetail.TabIndex = 2;
            // 
            // pnlKPointeAccent
            // 
            this.pnlKPointeAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlKPointeAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKPointeAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKPointeAccent.TabIndex = 3;
            // 
            // pnlKReleve
            // 
            this.pnlKReleve.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKReleve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKReleve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKReleve.Size = new System.Drawing.Size(250, 118);
            this.pnlKReleve.TabIndex = 2;
            this.pnlKReleve.Controls.Add(this.lblKReleveValeur);
            this.pnlKReleve.Controls.Add(this.lblKReleveTitre);
            this.pnlKReleve.Controls.Add(this.lblKReleveDetail);
            this.pnlKReleve.Controls.Add(this.pnlKReleveAccent);
            // 
            // lblKReleveValeur
            // 
            this.lblKReleveValeur.AutoSize = true;
            this.lblKReleveValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKReleveValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKReleveValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKReleveValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKReleveValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKReleveValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKReleveValeur.Text = "0";
            this.lblKReleveValeur.TabIndex = 0;
            // 
            // lblKReleveTitre
            // 
            this.lblKReleveTitre.AutoSize = true;
            this.lblKReleveTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKReleveTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKReleveTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKReleveTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKReleveTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKReleveTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKReleveTitre.Text = "Solde du relevé";
            this.lblKReleveTitre.TabIndex = 1;
            // 
            // lblKReleveDetail
            // 
            this.lblKReleveDetail.AutoSize = true;
            this.lblKReleveDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKReleveDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKReleveDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKReleveDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKReleveDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKReleveDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKReleveDetail.Text = "";
            this.lblKReleveDetail.TabIndex = 2;
            // 
            // pnlKReleveAccent
            // 
            this.pnlKReleveAccent.BackColor = System.Drawing.Color.FromArgb(176, 140, 28);
            this.pnlKReleveAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKReleveAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKReleveAccent.TabIndex = 3;
            // 
            // pnlKEcart
            // 
            this.pnlKEcart.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlKEcart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKEcart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKEcart.Size = new System.Drawing.Size(250, 118);
            this.pnlKEcart.TabIndex = 3;
            this.pnlKEcart.Controls.Add(this.lblKEcartValeur);
            this.pnlKEcart.Controls.Add(this.lblKEcartTitre);
            this.pnlKEcart.Controls.Add(this.lblKEcartDetail);
            this.pnlKEcart.Controls.Add(this.pnlKEcartAccent);
            // 
            // lblKEcartValeur
            // 
            this.lblKEcartValeur.AutoSize = true;
            this.lblKEcartValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKEcartValeur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKEcartValeur.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblKEcartValeur.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKEcartValeur.Size = new System.Drawing.Size(100, 40);
            this.lblKEcartValeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKEcartValeur.Text = "0";
            this.lblKEcartValeur.TabIndex = 0;
            // 
            // lblKEcartTitre
            // 
            this.lblKEcartTitre.AutoSize = true;
            this.lblKEcartTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKEcartTitre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKEcartTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKEcartTitre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 2);
            this.lblKEcartTitre.Size = new System.Drawing.Size(100, 36);
            this.lblKEcartTitre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKEcartTitre.Text = "Écart";
            this.lblKEcartTitre.TabIndex = 1;
            // 
            // lblKEcartDetail
            // 
            this.lblKEcartDetail.AutoSize = true;
            this.lblKEcartDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKEcartDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKEcartDetail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKEcartDetail.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblKEcartDetail.Size = new System.Drawing.Size(100, 30);
            this.lblKEcartDetail.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblKEcartDetail.Text = "";
            this.lblKEcartDetail.TabIndex = 2;
            // 
            // pnlKEcartAccent
            // 
            this.pnlKEcartAccent.BackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.pnlKEcartAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKEcartAccent.Size = new System.Drawing.Size(6, 100);
            this.pnlKEcartAccent.TabIndex = 3;
            // 
            // flowBarre
            // 
            this.flowBarre.AutoSize = true;
            this.flowBarre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowBarre.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowBarre.Size = new System.Drawing.Size(1100, 48);
            this.flowBarre.TabIndex = 3;
            this.flowBarre.Controls.Add(this.lblCompte);
            this.flowBarre.Controls.Add(this.cbCompte);
            this.flowBarre.Controls.Add(this.lblReleve);
            this.flowBarre.Controls.Add(this.nudReleve);
            this.flowBarre.Controls.Add(this.btnPointer);
            this.flowBarre.Controls.Add(this.btnDepointer);
            this.flowBarre.Controls.Add(this.btnActualiser);
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCompte.Location = new System.Drawing.Point(0, 0);
            this.lblCompte.Text = "Compte";
            this.lblCompte.Margin = new System.Windows.Forms.Padding(0, 9, 8, 0);
            this.lblCompte.TabIndex = 0;
            // 
            // cbCompte
            // 
            this.cbCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.Location = new System.Drawing.Point(0, 0);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(0, 4, 20, 8);
            this.cbCompte.Size = new System.Drawing.Size(300, 29);
            this.cbCompte.TabIndex = 1;
            this.cbCompte.SelectedIndexChanged += new System.EventHandler(this.cbCompte_SelectedIndexChanged);
            // 
            // lblReleve
            // 
            this.lblReleve.AutoSize = true;
            this.lblReleve.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleve.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblReleve.Location = new System.Drawing.Point(0, 0);
            this.lblReleve.Text = "Solde du relevé";
            this.lblReleve.Margin = new System.Windows.Forms.Padding(0, 9, 8, 0);
            this.lblReleve.TabIndex = 2;
            // 
            // nudReleve
            // 
            this.nudReleve.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReleve.Location = new System.Drawing.Point(0, 0);
            this.nudReleve.Margin = new System.Windows.Forms.Padding(0, 4, 20, 8);
            this.nudReleve.Size = new System.Drawing.Size(170, 29);
            this.nudReleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudReleve.ThousandsSeparator = true;
            this.nudReleve.TabIndex = 3;
            this.nudReleve.ValueChanged += new System.EventHandler(this.nudReleve_ValueChanged);
            // 
            // btnPointer
            // 
            this.btnPointer.BackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnPointer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointer.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnPointer.Location = new System.Drawing.Point(0, 0);
            this.btnPointer.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnPointer.Size = new System.Drawing.Size(190, 38);
            this.btnPointer.Text = "Pointer la sélection";
            this.btnPointer.UseVisualStyleBackColor = false;
            this.btnPointer.TabIndex = 4;
            this.btnPointer.FlatAppearance.BorderSize = 0;
            this.btnPointer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnPointer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnPointer.Click += new System.EventHandler(this.btnPointer_Click);
            // 
            // btnDepointer
            // 
            this.btnDepointer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDepointer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepointer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepointer.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnDepointer.Location = new System.Drawing.Point(0, 0);
            this.btnDepointer.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnDepointer.Size = new System.Drawing.Size(120, 38);
            this.btnDepointer.Text = "Dépointer";
            this.btnDepointer.UseVisualStyleBackColor = false;
            this.btnDepointer.TabIndex = 5;
            this.btnDepointer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnDepointer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnDepointer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnDepointer.Click += new System.EventHandler(this.btnDepointer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnActualiser.Location = new System.Drawing.Point(0, 0);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnActualiser.Size = new System.Drawing.Size(108, 38);
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.TabIndex = 6;
            this.btnActualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnActualiser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnActualiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // FrmRapprochement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlCarte);
            this.Controls.Add(this.lblAide);
            this.Controls.Add(this.tlpKpi);
            this.Controls.Add(this.flowBarre);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRapprochement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapprochement";
            this.Load += new System.EventHandler(this.FrmRapprochement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReleve)).EndInit();
            this.flowBarre.ResumeLayout(false);
            this.flowBarre.PerformLayout();
            this.pnlKEcart.ResumeLayout(false);
            this.pnlKEcart.PerformLayout();
            this.pnlKReleve.ResumeLayout(false);
            this.pnlKReleve.PerformLayout();
            this.pnlKPointe.ResumeLayout(false);
            this.pnlKPointe.PerformLayout();
            this.pnlKCompta.ResumeLayout(false);
            this.pnlKCompta.PerformLayout();
            this.tlpKpi.ResumeLayout(false);
            this.tlpKpi.PerformLayout();
            this.pnlCarte.ResumeLayout(false);
            this.pnlCarte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlCarte;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_5;
        private System.Windows.Forms.Label lblAide;
        private System.Windows.Forms.TableLayoutPanel tlpKpi;
        private System.Windows.Forms.Panel pnlKCompta;
        private System.Windows.Forms.Label lblKComptaValeur;
        private System.Windows.Forms.Label lblKComptaTitre;
        private System.Windows.Forms.Label lblKComptaDetail;
        private System.Windows.Forms.Panel pnlKComptaAccent;
        private System.Windows.Forms.Panel pnlKPointe;
        private System.Windows.Forms.Label lblKPointeValeur;
        private System.Windows.Forms.Label lblKPointeTitre;
        private System.Windows.Forms.Label lblKPointeDetail;
        private System.Windows.Forms.Panel pnlKPointeAccent;
        private System.Windows.Forms.Panel pnlKReleve;
        private System.Windows.Forms.Label lblKReleveValeur;
        private System.Windows.Forms.Label lblKReleveTitre;
        private System.Windows.Forms.Label lblKReleveDetail;
        private System.Windows.Forms.Panel pnlKReleveAccent;
        private System.Windows.Forms.Panel pnlKEcart;
        private System.Windows.Forms.Label lblKEcartValeur;
        private System.Windows.Forms.Label lblKEcartTitre;
        private System.Windows.Forms.Label lblKEcartDetail;
        private System.Windows.Forms.Panel pnlKEcartAccent;
        private System.Windows.Forms.FlowLayoutPanel flowBarre;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.ComboBox cbCompte;
        private System.Windows.Forms.Label lblReleve;
        private System.Windows.Forms.NumericUpDown nudReleve;
        private System.Windows.Forms.Button btnPointer;
        private System.Windows.Forms.Button btnDepointer;
        private System.Windows.Forms.Button btnActualiser;
    }
}
