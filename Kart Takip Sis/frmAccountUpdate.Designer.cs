namespace Kart_Takip_Sis
{
    partial class frmAccountUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountUpdate));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtNewAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAcc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(283, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(177, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "ACCOUNT UPDATE PANEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Username :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(25, 109);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(159, 20);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Old Acc. Name :";
            // 
            // txtUn
            // 
            this.txtUn.ForeColor = System.Drawing.Color.Black;
            this.txtUn.Location = new System.Drawing.Point(190, 70);
            this.txtUn.MaxLength = 15;
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(209, 28);
            this.txtUn.TabIndex = 0;
            // 
            // txtNewAcc
            // 
            this.txtNewAcc.ForeColor = System.Drawing.Color.Black;
            this.txtNewAcc.Location = new System.Drawing.Point(189, 142);
            this.txtNewAcc.MaxLength = 15;
            this.txtNewAcc.Name = "txtNewAcc";
            this.txtNewAcc.Size = new System.Drawing.Size(209, 28);
            this.txtNewAcc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "New Acc. Name :";
            // 
            // cmbAcc
            // 
            this.cmbAcc.Location = new System.Drawing.Point(190, 106);
            this.cmbAcc.MaxLength = 15;
            this.cmbAcc.Name = "cmbAcc";
            this.cmbAcc.Size = new System.Drawing.Size(208, 28);
            this.cmbAcc.TabIndex = 1;
            // 
            // frmAccountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 259);
            this.Controls.Add(this.cmbAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewAcc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtUn);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAccountUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Update Panel";
            this.Load += new System.EventHandler(this.frmAccountUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.TextBox txtNewAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAcc;
    }
}