namespace Kart_Takip_Sis
{
    partial class frmSignUp
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
            this.txtUn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUn
            // 
            this.txtUn.ForeColor = System.Drawing.Color.Black;
            this.txtUn.Location = new System.Drawing.Point(147, 92);
            this.txtUn.MaxLength = 15;
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(209, 28);
            this.txtUn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username :";
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(147, 128);
            this.txtPass.MaxLength = 15;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(209, 28);
            this.txtPass.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(147, 164);
            this.txtName.MaxLength = 15;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 28);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(147, 200);
            this.txtSurname.MaxLength = 15;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(209, 28);
            this.txtSurname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(142, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "NEW USER PANEL";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(147, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 48);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(253, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 329);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUn);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Panel";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}