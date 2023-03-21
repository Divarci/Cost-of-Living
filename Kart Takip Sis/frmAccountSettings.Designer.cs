namespace Kart_Takip_Sis
{
    partial class frmAccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSettings));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.btnAccUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(350, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 110);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNewAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAcc.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAcc.ForeColor = System.Drawing.Color.White;
            this.btnNewAcc.Location = new System.Drawing.Point(217, 29);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(127, 207);
            this.btnNewAcc.TabIndex = 1;
            this.btnNewAcc.Text = "NEW";
            this.btnNewAcc.UseVisualStyleBackColor = false;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // btnAccUp
            // 
            this.btnAccUp.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAccUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccUp.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccUp.ForeColor = System.Drawing.Color.White;
            this.btnAccUp.Location = new System.Drawing.Point(84, 82);
            this.btnAccUp.Name = "btnAccUp";
            this.btnAccUp.Size = new System.Drawing.Size(127, 110);
            this.btnAccUp.TabIndex = 0;
            this.btnAccUp.Text = "UPDATE";
            this.btnAccUp.UseVisualStyleBackColor = false;
            this.btnAccUp.Click += new System.EventHandler(this.btnAccUp_Click);
            // 
            // frmAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 266);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnAccUp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove/Update Accounts";
            this.Load += new System.EventHandler(this.frmAccountSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.Button btnAccUp;
    }
}