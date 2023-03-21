namespace Kart_Takip_Sis
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccRep = new System.Windows.Forms.Button();
            this.btnCompRep = new System.Windows.Forms.Button();
            this.cmbAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.cmbComp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(361, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 94);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAccRep
            // 
            this.btnAccRep.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAccRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccRep.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccRep.ForeColor = System.Drawing.Color.White;
            this.btnAccRep.Location = new System.Drawing.Point(228, 30);
            this.btnAccRep.Name = "btnAccRep";
            this.btnAccRep.Size = new System.Drawing.Size(127, 207);
            this.btnAccRep.TabIndex = 7;
            this.btnAccRep.Text = "BY ACCOUNT";
            this.btnAccRep.UseVisualStyleBackColor = false;
            this.btnAccRep.Click += new System.EventHandler(this.btnAccRep_Click);
            // 
            // btnCompRep
            // 
            this.btnCompRep.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCompRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompRep.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompRep.ForeColor = System.Drawing.Color.White;
            this.btnCompRep.Location = new System.Drawing.Point(28, 67);
            this.btnCompRep.Name = "btnCompRep";
            this.btnCompRep.Size = new System.Drawing.Size(194, 96);
            this.btnCompRep.TabIndex = 6;
            this.btnCompRep.Text = "BY COMPANY";
            this.btnCompRep.UseVisualStyleBackColor = false;
            this.btnCompRep.Click += new System.EventHandler(this.btnCompRep_Click);
            // 
            // cmbAcc
            // 
            this.cmbAcc.BackColor = System.Drawing.Color.OliveDrab;
            this.cmbAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAcc.ForeColor = System.Drawing.Color.White;
            this.cmbAcc.FormattingEnabled = true;
            this.cmbAcc.Location = new System.Drawing.Point(361, 199);
            this.cmbAcc.Name = "cmbAcc";
            this.cmbAcc.Size = new System.Drawing.Size(194, 33);
            this.cmbAcc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOTAL AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(361, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "BALANCE:";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcc.Location = new System.Drawing.Point(361, 58);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(26, 25);
            this.lblAcc.TabIndex = 13;
            this.lblAcc.Text = "0";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblComp.Location = new System.Drawing.Point(30, 202);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(26, 25);
            this.lblComp.TabIndex = 14;
            this.lblComp.Text = "0";
            // 
            // cmbComp
            // 
            this.cmbComp.BackColor = System.Drawing.Color.DarkOrchid;
            this.cmbComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbComp.ForeColor = System.Drawing.Color.White;
            this.cmbComp.FormattingEnabled = true;
            this.cmbComp.Location = new System.Drawing.Point(28, 30);
            this.cmbComp.Name = "cmbComp";
            this.cmbComp.Size = new System.Drawing.Size(194, 33);
            this.cmbComp.TabIndex = 15;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 266);
            this.Controls.Add(this.cmbComp);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAcc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccRep);
            this.Controls.Add(this.btnCompRep);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Menu";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccRep;
        private System.Windows.Forms.Button btnCompRep;
        private System.Windows.Forms.ComboBox cmbAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.ComboBox cmbComp;
    }
}