using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        // sql connection
        sql conn = new sql();

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            //button color
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //go back to login 
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Hide();
        }

        //temporary list which keeps the all usernames
        List<string> values = new List<string>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            //before algortim clear the list to prevent duplication
            values.Clear();
            // crypted informations
            byte[] text1 = ASCIIEncoding.ASCII.GetBytes(txtUn.Text);
            string text2 = Convert.ToBase64String(text1);

            byte[] text3 = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
            string text4 = Convert.ToBase64String(text3);
            //become bigger than 0 if there is an attempt to use same username
            int x = 0;
            //adds all usernames in to list
            SqlCommand cmd = new SqlCommand("select Username from Tbl_Users", conn.connection());
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                values.Add(rdr[0].ToString().Trim());
            }
            //check the list if there is a same username which is written to UN textbox
            for (int i = 0; i < values.Count; i++)
            {
                //if it is so x++
                if (text2 == values[i].ToString().Trim())
                {
                    x++;
                }
            }
            //it means user trying to add a username which is already taken
            if (x > 0)
            {
                MessageBox.Show("This Username has already Taken. Please choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUn.Focus();
            }
            //make sure there is no empt textbox 
            else if (txtName.Text == string.Empty || txtUn.Text == string.Empty || txtPass.Text == string.Empty || txtSurname.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All Boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //add record
            else
            {
                SqlCommand cmd2 = new SqlCommand("Insert into Tbl_Users (Username,Password,Name,Surname) values (@1,@2,@3,@4)",conn.connection());
                cmd2.Parameters.AddWithValue("@1", text2);
                cmd2.Parameters.AddWithValue("@2", text4);
                cmd2.Parameters.AddWithValue("@3", txtName.Text);
                cmd2.Parameters.AddWithValue("@4", txtSurname.Text);
                cmd2.ExecuteNonQuery();
                conn.connection().Close();

                MessageBox.Show("User Has Been Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear form 
                txtUn.Text = "";
                txtPass.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                txtUn.Focus();
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar= true;
        }
    }
}
