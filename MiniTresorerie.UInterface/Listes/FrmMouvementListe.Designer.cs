namespace MiniTresorerie.UInterface
{
    partial class FrmMouvementListe
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
            this.col_dgv_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPied = new System.Windows.Forms.Label();
            this.flowFiltres = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDu = new System.Windows.Forms.Label();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.lblAu = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.cbCompte = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.flowBarre = new System.Windows.Forms.FlowLayoutPanel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecette = new System.Windows.Forms.Button();
            this.btnDepense = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnRecu = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlCarte.SuspendLayout();
            this.flowFiltres.SuspendLayout();
            this.flowBarre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCarte
            // 
            this.pnlCarte.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarte.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCarte.Size = new System.Drawing.Size(1100, 560);
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
            this.col_dgv_5,
            this.col_dgv_6,
            this.col_dgv_7});
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
            this.dgv.MultiSelect = false;
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
            this.col_dgv_0.FillWeight = 95F;
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
            this.col_dgv_2.FillWeight = 260F;
            this.col_dgv_2.HeaderText = "Libellé";
            this.col_dgv_2.MinimumWidth = 6;
            this.col_dgv_2.Name = "colMvtLibelle_dgv";
            this.col_dgv_2.ReadOnly = true;
            this.col_dgv_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_3
            // 
            this.col_dgv_3.DataPropertyName = "CatLibelle";
            this.col_dgv_3.FillWeight = 150F;
            this.col_dgv_3.HeaderText = "Catégorie";
            this.col_dgv_3.MinimumWidth = 6;
            this.col_dgv_3.Name = "colCatLibelle_dgv";
            this.col_dgv_3.ReadOnly = true;
            this.col_dgv_3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_4
            // 
            this.col_dgv_4.DataPropertyName = "Centre";
            this.col_dgv_4.FillWeight = 130F;
            this.col_dgv_4.HeaderText = "Centre";
            this.col_dgv_4.MinimumWidth = 6;
            this.col_dgv_4.Name = "colCentre_dgv";
            this.col_dgv_4.ReadOnly = true;
            this.col_dgv_4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_5
            // 
            this.col_dgv_5.DataPropertyName = "CptCode";
            this.col_dgv_5.FillWeight = 95F;
            this.col_dgv_5.HeaderText = "Compte";
            this.col_dgv_5.MinimumWidth = 6;
            this.col_dgv_5.Name = "colCptCode_dgv";
            this.col_dgv_5.ReadOnly = true;
            this.col_dgv_5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_6
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "+#,##0;-#,##0";
            this.col_dgv_6.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgv_6.DataPropertyName = "MontantSigne";
            this.col_dgv_6.FillWeight = 140F;
            this.col_dgv_6.HeaderText = "Montant (FCFA)";
            this.col_dgv_6.MinimumWidth = 6;
            this.col_dgv_6.Name = "colMontantSigne_dgv";
            this.col_dgv_6.ReadOnly = true;
            this.col_dgv_6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // col_dgv_7
            // 
            this.col_dgv_7.DataPropertyName = "Etat";
            this.col_dgv_7.FillWeight = 95F;
            this.col_dgv_7.HeaderText = "État";
            this.col_dgv_7.MinimumWidth = 6;
            this.col_dgv_7.Name = "colEtat_dgv";
            this.col_dgv_7.ReadOnly = true;
            this.col_dgv_7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // lblPied
            // 
            this.lblPied.AutoSize = true;
            this.lblPied.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPied.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPied.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPied.Size = new System.Drawing.Size(1100, 34);
            this.lblPied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPied.Text = "";
            this.lblPied.TabIndex = 1;
            // 
            // flowFiltres
            // 
            this.flowFiltres.AutoSize = true;
            this.flowFiltres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowFiltres.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowFiltres.Size = new System.Drawing.Size(1100, 44);
            this.flowFiltres.TabIndex = 2;
            this.flowFiltres.Controls.Add(this.lblDu);
            this.flowFiltres.Controls.Add(this.dtDebut);
            this.flowFiltres.Controls.Add(this.lblAu);
            this.flowFiltres.Controls.Add(this.dtFin);
            this.flowFiltres.Controls.Add(this.cbCompte);
            this.flowFiltres.Controls.Add(this.cbType);
            this.flowFiltres.Controls.Add(this.cbEtat);
            // 
            // lblDu
            // 
            this.lblDu.AutoSize = true;
            this.lblDu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDu.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDu.Location = new System.Drawing.Point(0, 0);
            this.lblDu.Text = "Du";
            this.lblDu.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblDu.TabIndex = 0;
            // 
            // dtDebut
            // 
            this.dtDebut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDebut.Location = new System.Drawing.Point(0, 0);
            this.dtDebut.Margin = new System.Windows.Forms.Padding(0, 4, 14, 8);
            this.dtDebut.Size = new System.Drawing.Size(130, 29);
            this.dtDebut.ShowCheckBox = true;
            this.dtDebut.Checked = false;
            this.dtDebut.TabIndex = 1;
            this.dtDebut.ValueChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAu.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblAu.Location = new System.Drawing.Point(0, 0);
            this.lblAu.Text = "Au";
            this.lblAu.Margin = new System.Windows.Forms.Padding(0, 9, 6, 0);
            this.lblAu.TabIndex = 2;
            // 
            // dtFin
            // 
            this.dtFin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(0, 0);
            this.dtFin.Margin = new System.Windows.Forms.Padding(0, 4, 14, 8);
            this.dtFin.Size = new System.Drawing.Size(130, 29);
            this.dtFin.ShowCheckBox = true;
            this.dtFin.Checked = false;
            this.dtFin.TabIndex = 3;
            this.dtFin.ValueChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // cbCompte
            // 
            this.cbCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompte.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.Location = new System.Drawing.Point(0, 0);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(0, 4, 14, 8);
            this.cbCompte.Size = new System.Drawing.Size(210, 29);
            this.cbCompte.TabIndex = 4;
            this.cbCompte.SelectedIndexChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(0, 0);
            this.cbType.Margin = new System.Windows.Forms.Padding(0, 4, 14, 8);
            this.cbType.Size = new System.Drawing.Size(140, 29);
            this.cbType.TabIndex = 5;
            this.cbType.Items.AddRange(new object[] {
            "Tous les types",
            "Recettes",
            "Dépenses"});
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // cbEtat
            // 
            this.cbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(0, 0);
            this.cbEtat.Margin = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.cbEtat.Size = new System.Drawing.Size(140, 29);
            this.cbEtat.TabIndex = 6;
            this.cbEtat.Items.AddRange(new object[] {
            "Tous les états",
            "Pointés",
            "À pointer"});
            this.cbEtat.SelectedIndexChanged += new System.EventHandler(this.Filtre_Changed);
            // 
            // flowBarre
            // 
            this.flowBarre.AutoSize = true;
            this.flowBarre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowBarre.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowBarre.Size = new System.Drawing.Size(1100, 46);
            this.flowBarre.TabIndex = 3;
            this.flowBarre.Controls.Add(this.txtRecherche);
            this.flowBarre.Controls.Add(this.btnRecette);
            this.flowBarre.Controls.Add(this.btnDepense);
            this.flowBarre.Controls.Add(this.btnModifier);
            this.flowBarre.Controls.Add(this.btnConsulter);
            this.flowBarre.Controls.Add(this.btnRecu);
            this.flowBarre.Controls.Add(this.btnSupprimer);
            this.flowBarre.Controls.Add(this.btnActualiser);
            this.flowBarre.Controls.Add(this.btnImprimer);
            this.flowBarre.Controls.Add(this.btnPdf);
            this.flowBarre.Controls.Add(this.btnExcel);
            // 
            // txtRecherche
            // 
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtRecherche.Location = new System.Drawing.Point(0, 0);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(0, 4, 14, 8);
            this.txtRecherche.PlaceholderText = "Rechercher…";
            this.txtRecherche.Size = new System.Drawing.Size(280, 29);
            this.txtRecherche.TabIndex = 0;
            // 
            // btnRecette
            // 
            this.btnRecette.BackColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecette.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecette.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRecette.Location = new System.Drawing.Point(0, 0);
            this.btnRecette.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnRecette.Size = new System.Drawing.Size(100, 38);
            this.btnRecette.Text = "Recette";
            this.btnRecette.UseVisualStyleBackColor = false;
            this.btnRecette.TabIndex = 1;
            this.btnRecette.FlatAppearance.BorderSize = 0;
            this.btnRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnRecette.Click += new System.EventHandler(this.btnRecette_Click);
            // 
            // btnDepense
            // 
            this.btnDepense.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepense.ForeColor = System.Drawing.Color.FromArgb(2, 44, 34);
            this.btnDepense.Location = new System.Drawing.Point(0, 0);
            this.btnDepense.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnDepense.Size = new System.Drawing.Size(100, 38);
            this.btnDepense.Text = "Dépense";
            this.btnDepense.UseVisualStyleBackColor = false;
            this.btnDepense.TabIndex = 2;
            this.btnDepense.FlatAppearance.BorderSize = 0;
            this.btnDepense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(176, 140, 28);
            this.btnDepense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 190, 70);
            this.btnDepense.Click += new System.EventHandler(this.btnDepense_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnModifier.Location = new System.Drawing.Point(0, 0);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnModifier.Size = new System.Drawing.Size(104, 38);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.TabIndex = 3;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnConsulter
            // 
            this.btnConsulter.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnConsulter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnConsulter.Location = new System.Drawing.Point(0, 0);
            this.btnConsulter.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnConsulter.Size = new System.Drawing.Size(110, 38);
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.UseVisualStyleBackColor = false;
            this.btnConsulter.TabIndex = 4;
            this.btnConsulter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnConsulter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnConsulter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // btnRecu
            // 
            this.btnRecu.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRecu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecu.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnRecu.Location = new System.Drawing.Point(0, 0);
            this.btnRecu.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnRecu.Size = new System.Drawing.Size(80, 38);
            this.btnRecu.Text = "Reçu";
            this.btnRecu.UseVisualStyleBackColor = false;
            this.btnRecu.TabIndex = 5;
            this.btnRecu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnRecu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnRecu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnRecu.Click += new System.EventHandler(this.btnRecu_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSupprimer.Location = new System.Drawing.Point(0, 0);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnSupprimer.Size = new System.Drawing.Size(112, 38);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnActualiser.Location = new System.Drawing.Point(0, 0);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnActualiser.Size = new System.Drawing.Size(108, 38);
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.TabIndex = 7;
            this.btnActualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnActualiser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnActualiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnImprimer.Location = new System.Drawing.Point(0, 0);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnImprimer.Size = new System.Drawing.Size(100, 38);
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.TabIndex = 8;
            this.btnImprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnImprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnPdf.Location = new System.Drawing.Point(0, 0);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnPdf.Size = new System.Drawing.Size(70, 38);
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.TabIndex = 9;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(6, 78, 59);
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnExcel.Size = new System.Drawing.Size(80, 38);
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.TabIndex = 10;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 229);
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmMouvementListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 247, 245);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlCarte);
            this.Controls.Add(this.lblPied);
            this.Controls.Add(this.flowFiltres);
            this.Controls.Add(this.flowBarre);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMouvementListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal des mouvements de trésorerie";
            this.Load += new System.EventHandler(this.FrmMouvementListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flowBarre.ResumeLayout(false);
            this.flowBarre.PerformLayout();
            this.flowFiltres.ResumeLayout(false);
            this.flowFiltres.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_7;
        private System.Windows.Forms.Label lblPied;
        private System.Windows.Forms.FlowLayoutPanel flowFiltres;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.ComboBox cbCompte;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.FlowLayoutPanel flowBarre;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecette;
        private System.Windows.Forms.Button btnDepense;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Button btnRecu;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
    }
}
