namespace Kart_Takip_Sis
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txtUn
            // 
            this.txtUn.Location = new System.Drawing.Point(132, 86);
            this.txtUn.MaxLength = 15;
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(212, 28);
            this.txtUn.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 120);
            this.txtPass.MaxLength = 15;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 28);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(132, 159);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(104, 37);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSu
            // 
            this.btnSu.BackColor = System.Drawing.Color.Teal;
            this.btnSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSu.ForeColor = System.Drawing.Color.White;
            this.btnSu.Location = new System.Drawing.Point(240, 159);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(104, 37);
            this.btnSu.TabIndex = 4;
            this.btnSu.Text = "Sign Up";
            this.btnSu.UseVisualStyleBackColor = false;
            this.btnSu.Click += new System.EventHandler(this.btnSu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kart_Takip_Sis.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(370, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "USER ACCESS";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSu);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

