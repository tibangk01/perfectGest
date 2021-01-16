namespace GestAlone
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVD = new System.Windows.Forms.TextBox();
            this.tbPD = new System.Windows.Forms.TextBox();
            this.tbND = new System.Windows.Forms.TextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgD = new System.Windows.Forms.Label();
            this.cbTD = new System.Windows.Forms.ComboBox();
            this.btnResetD = new System.Windows.Forms.Button();
            this.btnSaveD = new System.Windows.Forms.Button();
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.culumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReportD = new System.Windows.Forms.Button();
            this.tbSearchD = new System.Windows.Forms.TextBox();
            this.btnSearchD = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationDeLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesTypesDeDonationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdReportD = new System.Drawing.Printing.PrintDocument();
            this.dgvReportD = new System.Windows.Forms.DataGridView();
            this.column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type De Donation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Donateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom Donateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valeur De La Donation";
            // 
            // tbVD
            // 
            this.tbVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVD.Location = new System.Drawing.Point(215, 118);
            this.tbVD.Name = "tbVD";
            this.tbVD.Size = new System.Drawing.Size(237, 26);
            this.tbVD.TabIndex = 4;
            this.tbVD.Enter += new System.EventHandler(this.tbVD_Enter);
            // 
            // tbPD
            // 
            this.tbPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPD.Location = new System.Drawing.Point(215, 86);
            this.tbPD.Name = "tbPD";
            this.tbPD.Size = new System.Drawing.Size(237, 26);
            this.tbPD.TabIndex = 3;
            this.tbPD.Enter += new System.EventHandler(this.tbPD_Enter);
            // 
            // tbND
            // 
            this.tbND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbND.Location = new System.Drawing.Point(215, 54);
            this.tbND.Name = "tbND";
            this.tbND.Size = new System.Drawing.Size(237, 26);
            this.tbND.TabIndex = 2;
            this.tbND.Enter += new System.EventHandler(this.tbND_Enter);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.cbTD);
            this.bunifuCards1.Controls.Add(this.btnResetD);
            this.bunifuCards1.Controls.Add(this.btnSaveD);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.tbND);
            this.bunifuCards1.Controls.Add(this.tbPD);
            this.bunifuCards1.Controls.Add(this.tbVD);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(288, 86);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(468, 266);
            this.bunifuCards1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblMsgD);
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 45);
            this.panel1.TabIndex = 11;
            // 
            // lblMsgD
            // 
            this.lblMsgD.AutoSize = true;
            this.lblMsgD.BackColor = System.Drawing.Color.White;
            this.lblMsgD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgD.ForeColor = System.Drawing.Color.Red;
            this.lblMsgD.Location = new System.Drawing.Point(109, 14);
            this.lblMsgD.Name = "lblMsgD";
            this.lblMsgD.Size = new System.Drawing.Size(0, 16);
            this.lblMsgD.TabIndex = 1;
            // 
            // cbTD
            // 
            this.cbTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTD.FormattingEnabled = true;
            this.cbTD.Location = new System.Drawing.Point(215, 20);
            this.cbTD.Name = "cbTD";
            this.cbTD.Size = new System.Drawing.Size(237, 28);
            this.cbTD.TabIndex = 1;
            // 
            // btnResetD
            // 
            this.btnResetD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetD.Location = new System.Drawing.Point(232, 169);
            this.btnResetD.Name = "btnResetD";
            this.btnResetD.Size = new System.Drawing.Size(114, 32);
            this.btnResetD.TabIndex = 6;
            this.btnResetD.Text = "Annuler";
            this.btnResetD.UseVisualStyleBackColor = true;
            this.btnResetD.Click += new System.EventHandler(this.btnResetD_Click);
            // 
            // btnSaveD
            // 
            this.btnSaveD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveD.Location = new System.Drawing.Point(112, 169);
            this.btnSaveD.Name = "btnSaveD";
            this.btnSaveD.Size = new System.Drawing.Size(114, 32);
            this.btnSaveD.TabIndex = 5;
            this.btnSaveD.Text = "Enregistrer";
            this.btnSaveD.UseVisualStyleBackColor = true;
            this.btnSaveD.Click += new System.EventHandler(this.btnSaveD_Click);
            // 
            // dgvD
            // 
            this.dgvD.AllowUserToAddRows = false;
            this.dgvD.AllowUserToDeleteRows = false;
            this.dgvD.AllowUserToResizeColumns = false;
            this.dgvD.AllowUserToResizeRows = false;
            this.dgvD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvD.ColumnHeadersHeight = 30;
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.Column1,
            this.c,
            this.e,
            this.culumn1,
            this.d,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvD.Location = new System.Drawing.Point(42, 421);
            this.dgvD.MultiSelect = false;
            this.dgvD.Name = "dgvD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvD.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvD.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvD.RowTemplate.Height = 30;
            this.dgvD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvD.Size = new System.Drawing.Size(974, 254);
            this.dgvD.TabIndex = 10;
            this.dgvD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvD_CellClick);
            // 
            // a
            // 
            this.a.FillWeight = 10F;
            this.a.HeaderText = "numDonation";
            this.a.Name = "a";
            this.a.Visible = false;
            // 
            // b
            // 
            this.b.FillWeight = 10F;
            this.b.HeaderText = "numTypeDonation";
            this.b.Name = "b";
            this.b.Visible = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 130F;
            this.Column1.HeaderText = "Date D\'enreg.";
            this.Column1.Name = "Column1";
            // 
            // c
            // 
            this.c.FillWeight = 120F;
            this.c.HeaderText = "Nom Donateur";
            this.c.Name = "c";
            // 
            // e
            // 
            this.e.FillWeight = 140F;
            this.e.HeaderText = "Prénom Donateur";
            this.e.Name = "e";
            // 
            // culumn1
            // 
            this.culumn1.FillWeight = 140F;
            this.culumn1.HeaderText = "Type De Don";
            this.culumn1.Name = "culumn1";
            // 
            // d
            // 
            this.d.FillWeight = 120F;
            this.d.HeaderText = "Valeur Du Don";
            this.d.Name = "d";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnReportD
            // 
            this.btnReportD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportD.Location = new System.Drawing.Point(42, 383);
            this.btnReportD.Name = "btnReportD";
            this.btnReportD.Size = new System.Drawing.Size(114, 32);
            this.btnReportD.TabIndex = 9;
            this.btnReportD.Text = "Imprimer";
            this.btnReportD.UseVisualStyleBackColor = true;
            this.btnReportD.Click += new System.EventHandler(this.btnReportD_Click);
            // 
            // tbSearchD
            // 
            this.tbSearchD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchD.Location = new System.Drawing.Point(830, 389);
            this.tbSearchD.Name = "tbSearchD";
            this.tbSearchD.Size = new System.Drawing.Size(186, 26);
            this.tbSearchD.TabIndex = 8;
            // 
            // btnSearchD
            // 
            this.btnSearchD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchD.Location = new System.Drawing.Point(713, 386);
            this.btnSearchD.Name = "btnSearchD";
            this.btnSearchD.Size = new System.Drawing.Size(114, 32);
            this.btnSearchD.TabIndex = 7;
            this.btnSearchD.Text = "Rechercher";
            this.btnSearchD.UseVisualStyleBackColor = true;
            this.btnSearchD.Click += new System.EventHandler(this.btnSearchD_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.configurationDeLapplicationToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1059, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accueilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // configurationDeLapplicationToolStripMenuItem
            // 
            this.configurationDeLapplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesTypesDeDonationToolStripMenuItem});
            this.configurationDeLapplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationDeLapplicationToolStripMenuItem.Name = "configurationDeLapplicationToolStripMenuItem";
            this.configurationDeLapplicationToolStripMenuItem.Size = new System.Drawing.Size(258, 25);
            this.configurationDeLapplicationToolStripMenuItem.Text = "Configuration De L\'application";
            // 
            // gérerLesTypesDeDonationToolStripMenuItem
            // 
            this.gérerLesTypesDeDonationToolStripMenuItem.Name = "gérerLesTypesDeDonationToolStripMenuItem";
            this.gérerLesTypesDeDonationToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.gérerLesTypesDeDonationToolStripMenuItem.Text = "Gérer Les Types De Donations";
            this.gérerLesTypesDeDonationToolStripMenuItem.Click += new System.EventHandler(this.gérerLesTypesDeDonationToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.aProposToolStripMenuItem.Text = "A Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // pdReportD
            // 
            this.pdReportD.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.pdReportD_BeginPrint);
            this.pdReportD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdReportD_PrintPage);
            // 
            // dgvReportD
            // 
            this.dgvReportD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column0,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7});
            this.dgvReportD.Location = new System.Drawing.Point(54, 358);
            this.dgvReportD.Name = "dgvReportD";
            this.dgvReportD.RowHeadersVisible = false;
            this.dgvReportD.Size = new System.Drawing.Size(563, 187);
            this.dgvReportD.TabIndex = 14;
            this.dgvReportD.Visible = false;
            // 
            // column0
            // 
            this.column0.FillWeight = 20F;
            this.column0.HeaderText = "N°";
            this.column0.Name = "column0";
            this.column0.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Nom et Prénom Donateur";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 130F;
            this.Column3.HeaderText = "Type De Don";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Valeur Du Don";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date D\'enregistrement";
            this.Column7.Name = "Column7";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 701);
            this.Controls.Add(this.dgvReportD);
            this.Controls.Add(this.btnSearchD);
            this.Controls.Add(this.tbSearchD);
            this.Controls.Add(this.btnReportD);
            this.Controls.Add(this.dgvD);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERFECT-GEST | Accueil";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVD;
        private System.Windows.Forms.TextBox tbPD;
        private System.Windows.Forms.TextBox tbND;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btnResetD;
        private System.Windows.Forms.Button btnSaveD;
        private System.Windows.Forms.ComboBox cbTD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.Button btnReportD;
        private System.Windows.Forms.TextBox tbSearchD;
        private System.Windows.Forms.Button btnSearchD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationDeLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesTypesDeDonationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label lblMsgD;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn culumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Drawing.Printing.PrintDocument pdReportD;
        private System.Windows.Forms.DataGridView dgvReportD;
        private System.Windows.Forms.DataGridViewTextBoxColumn column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}