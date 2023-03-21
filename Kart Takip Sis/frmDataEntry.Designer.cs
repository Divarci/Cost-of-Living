namespace Kart_Takip_Sis
{
    partial class frmDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rchDesc = new System.Windows.Forms.RichTextBox();
            this.rdexp = new System.Windows.Forms.RadioButton();
            this.rdinc = new System.Windows.Forms.RadioButton();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbAcc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.dgwDataEntry = new System.Windows.Forms.DataGridView();
            this.mskAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.mskAmount);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.rchDesc);
            this.groupBox1.Controls.Add(this.rdexp);
            this.groupBox1.Controls.Add(this.rdinc);
            this.groupBox1.Controls.Add(this.txtComp);
            this.groupBox1.Controls.Add(this.mskDate);
            this.groupBox1.Controls.Add(this.cmbAcc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(598, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 59);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(469, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 59);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(338, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 59);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rchDesc
            // 
            this.rchDesc.Location = new System.Drawing.Point(729, 47);
            this.rchDesc.MaxLength = 125;
            this.rchDesc.Name = "rchDesc";
            this.rchDesc.Size = new System.Drawing.Size(320, 110);
            this.rchDesc.TabIndex = 3;
            this.rchDesc.Text = "";
            // 
            // rdexp
            // 
            this.rdexp.AutoSize = true;
            this.rdexp.Location = new System.Drawing.Point(14, 98);
            this.rdexp.Name = "rdexp";
            this.rdexp.Size = new System.Drawing.Size(109, 24);
            this.rdexp.TabIndex = 4;
            this.rdexp.TabStop = true;
            this.rdexp.Text = "Expense";
            this.rdexp.UseVisualStyleBackColor = true;
            // 
            // rdinc
            // 
            this.rdinc.AutoSize = true;
            this.rdinc.Location = new System.Drawing.Point(14, 133);
            this.rdinc.Name = "rdinc";
            this.rdinc.Size = new System.Drawing.Size(102, 24);
            this.rdinc.TabIndex = 5;
            this.rdinc.TabStop = true;
            this.rdinc.Text = "Income";
            this.rdinc.UseVisualStyleBackColor = true;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(417, 47);
            this.txtComp.MaxLength = 22;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(306, 28);
            this.txtComp.TabIndex = 2;
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(287, 47);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(124, 28);
            this.mskDate.TabIndex = 1;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbAcc
            // 
            this.cmbAcc.FormattingEnabled = true;
            this.cmbAcc.Items.AddRange(new object[] {
            "All Accounts"});
            this.cmbAcc.Location = new System.Drawing.Point(14, 47);
            this.cmbAcc.MaxLength = 15;
            this.cmbAcc.Name = "cmbAcc";
            this.cmbAcc.Size = new System.Drawing.Size(267, 28);
            this.cmbAcc.TabIndex = 0;
            this.cmbAcc.SelectedIndexChanged += new System.EventHandler(this.cmbAcc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Account";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnUserMenu);
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 678);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(593, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(635, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 31);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnUserMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMenu.ForeColor = System.Drawing.Color.Black;
            this.btnUserMenu.Location = new System.Drawing.Point(850, 24);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(185, 31);
            this.btnUserMenu.TabIndex = 13;
            this.btnUserMenu.Text = "USER MENU";
            this.btnUserMenu.UseVisualStyleBackColor = false;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Account",
            "Date",
            "Company",
            "Description",
            "Amount",
            "Expense",
            "Income"});
            this.cmbSearch.Location = new System.Drawing.Point(358, 27);
            this.cmbSearch.MaxLength = 15;
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(229, 28);
            this.cmbSearch.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "In";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 26);
            this.txtSearch.MaxLength = 25;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 28);
            this.txtSearch.TabIndex = 10;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfo.Controls.Add(this.dgwDataEntry);
            this.grpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpInfo.ForeColor = System.Drawing.Color.Black;
            this.grpInfo.Location = new System.Drawing.Point(12, 186);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1055, 486);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            // 
            // dgwDataEntry
            // 
            this.dgwDataEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDataEntry.BackgroundColor = System.Drawing.Color.White;
            this.dgwDataEntry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwDataEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwDataEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDataEntry.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDataEntry.GridColor = System.Drawing.Color.Black;
            this.dgwDataEntry.Location = new System.Drawing.Point(3, 28);
            this.dgwDataEntry.Name = "dgwDataEntry";
            this.dgwDataEntry.RowHeadersVisible = false;
            this.dgwDataEntry.RowHeadersWidth = 51;
            this.dgwDataEntry.RowTemplate.Height = 24;
            this.dgwDataEntry.Size = new System.Drawing.Size(1049, 455);
            this.dgwDataEntry.TabIndex = 0;
            this.dgwDataEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDataEntry_CellClick);
            this.dgwDataEntry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDataEntry_CellDoubleClick);
            // 
            // mskAmount
            // 
            this.mskAmount.Location = new System.Drawing.Point(160, 129);
            this.mskAmount.MaxLength = 18;
            this.mskAmount.Name = "mskAmount";
            this.mskAmount.Size = new System.Drawing.Size(172, 28);
            this.mskAmount.TabIndex = 6;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 765);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDataEntry";
            this.Load += new System.EventHandler(this.frmDataEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rchDesc;
        private System.Windows.Forms.RadioButton rdexp;
        private System.Windows.Forms.RadioButton rdinc;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.ComboBox cmbAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgwDataEntry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mskAmount;
    }
}