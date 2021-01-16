namespace GestAlone
{
    partial class GestionTypeDonation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgATD = new System.Windows.Forms.Label();
            this.btnResetTD = new System.Windows.Forms.Button();
            this.btnSaveTD = new System.Windows.Forms.Button();
            this.tbATD = new System.Windows.Forms.TextBox();
            this.dgvTypeDonation = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeDonation)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.btnResetTD);
            this.bunifuCards1.Controls.Add(this.btnSaveTD);
            this.bunifuCards1.Controls.Add(this.tbATD);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(197, 55);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(368, 192);
            this.bunifuCards1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblMsgATD);
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 45);
            this.panel1.TabIndex = 12;
            // 
            // lblMsgATD
            // 
            this.lblMsgATD.AutoSize = true;
            this.lblMsgATD.BackColor = System.Drawing.Color.White;
            this.lblMsgATD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgATD.ForeColor = System.Drawing.Color.Red;
            this.lblMsgATD.Location = new System.Drawing.Point(73, 13);
            this.lblMsgATD.Name = "lblMsgATD";
            this.lblMsgATD.Size = new System.Drawing.Size(0, 16);
            this.lblMsgATD.TabIndex = 0;
            // 
            // btnResetTD
            // 
            this.btnResetTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTD.Location = new System.Drawing.Point(186, 77);
            this.btnResetTD.Name = "btnResetTD";
            this.btnResetTD.Size = new System.Drawing.Size(114, 32);
            this.btnResetTD.TabIndex = 11;
            this.btnResetTD.Text = "Annuler";
            this.btnResetTD.UseVisualStyleBackColor = true;
            this.btnResetTD.Click += new System.EventHandler(this.btnResetTD_Click);
            // 
            // btnSaveTD
            // 
            this.btnSaveTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTD.Location = new System.Drawing.Point(66, 77);
            this.btnSaveTD.Name = "btnSaveTD";
            this.btnSaveTD.Size = new System.Drawing.Size(114, 32);
            this.btnSaveTD.TabIndex = 10;
            this.btnSaveTD.Text = "Enregistrer";
            this.btnSaveTD.UseVisualStyleBackColor = true;
            this.btnSaveTD.Click += new System.EventHandler(this.btnSaveTD_Click);
            // 
            // tbATD
            // 
            this.tbATD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbATD.Location = new System.Drawing.Point(41, 36);
            this.tbATD.Name = "tbATD";
            this.tbATD.Size = new System.Drawing.Size(279, 26);
            this.tbATD.TabIndex = 9;
            this.tbATD.Enter += new System.EventHandler(this.tbATD_Enter);
            // 
            // dgvTypeDonation
            // 
            this.dgvTypeDonation.AllowUserToAddRows = false;
            this.dgvTypeDonation.AllowUserToDeleteRows = false;
            this.dgvTypeDonation.AllowUserToResizeColumns = false;
            this.dgvTypeDonation.AllowUserToResizeRows = false;
            this.dgvTypeDonation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypeDonation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeDonation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTypeDonation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeDonation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypeDonation.ColumnHeadersHeight = 40;
            this.dgvTypeDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTypeDonation.ColumnHeadersVisible = false;
            this.dgvTypeDonation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTypeDonation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTypeDonation.Location = new System.Drawing.Point(51, 280);
            this.dgvTypeDonation.MultiSelect = false;
            this.dgvTypeDonation.Name = "dgvTypeDonation";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeDonation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTypeDonation.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTypeDonation.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTypeDonation.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTypeDonation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTypeDonation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeDonation.Size = new System.Drawing.Size(646, 237);
            this.dgvTypeDonation.TabIndex = 10;
            this.dgvTypeDonation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeDonation_CellClick);
            // 
            // a
            // 
            this.a.FillWeight = 30F;
            this.a.HeaderText = "numTypeDonation";
            this.a.Name = "a";
            this.a.Visible = false;
            // 
            // b
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.b.DefaultCellStyle = dataGridViewCellStyle2;
            this.b.FillWeight = 200F;
            this.b.HeaderText = "Libellé Des Types De Donations";
            this.b.Name = "b";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GestionTypeDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 542);
            this.Controls.Add(this.dgvTypeDonation);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "GestionTypeDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERFECT-GEST | Gestion Des Types De Donations";
            this.Activated += new System.EventHandler(this.GestionTypeDonation_Activated);
            this.Load += new System.EventHandler(this.GestionTypeDonation_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeDonation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TextBox tbATD;
        private System.Windows.Forms.Button btnResetTD;
        private System.Windows.Forms.Button btnSaveTD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTypeDonation;
        private System.Windows.Forms.Label lblMsgATD;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}