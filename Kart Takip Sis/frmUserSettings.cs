using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmUserSettings : Form
    {
        public frmUserSettings()
        {
            InitializeComponent();
        }
        //sql connecton
        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //cyrted new informations
            byte[] code = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
            string coded = Convert.ToBase64String(code);

            byte[] code2 = ASCIIEncoding.ASCII.GetBytes(txtUn.Text);
            string coded2 = Convert.ToBase64String(code2);

            //Temporary values
            int x = 0;
            List<string> values = new List<string>();

            SqlCommand cmd = new SqlCommand("select Username from Tbl_Users", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                values.Add(dr[0].ToString().Trim());
            }
            //check the list if there is a same username which is written to UN textbox
            for (int i = 0; i < values.Count; i++)
            {
                //if it is so x++
                if (coded2 == values[i].ToString().Trim())
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

                //updated database recors
                SqlCommand cmd2 = new SqlCommand("Update Tbl_Users set Username=@p1,Password=@p2,Name=@p3,Surname=@p4 where UserId=@p5", conn.connection());
                cmd2.Parameters.AddWithValue("@p1", coded2);
                cmd2.Parameters.AddWithValue("@p2", coded);
                cmd2.Parameters.AddWithValue("@p3", txtName.Text);
                cmd2.Parameters.AddWithValue("@p4", txtSurname.Text);
                cmd2.Parameters.AddWithValue("@p5", trnsId);
                cmd2.ExecuteNonQuery();
                conn.connection().Close();

                MessageBox.Show("User has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSignInMainMenu fr = new frmSignInMainMenu();

                //leads you to previous manu
                fr.trnsName = txtName.Text;
                fr.trnsUn = coded2;
                fr.trnsPass = coded;
                fr.trnsSurname = txtSurname.Text;

                fr.Show();
                this.Hide();
            }
        }

        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            //button color
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

            //encyrpted informations
            byte[] code = Convert.FromBase64String(trnsUn);
            string coded = ASCIIEncoding.ASCII.GetString(code);

            byte[] code2 = Convert.FromBase64String(trnsPass);
            string coded2 = ASCIIEncoding.ASCII.GetString(code2);

            txtUn.Text = coded;
            txtPass.Text = coded2;
            txtName.Text = trnsName;
            txtSurname.Text = trnsSurname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //leads you to Main Menu
            frmSignInMainMenu fr = new frmSignInMainMenu();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }
    }
}
