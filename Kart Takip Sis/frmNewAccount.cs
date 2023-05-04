using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmNewAccount : Form
    {
        public frmNewAccount()
        {
            InitializeComponent();
        }

        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            //button colour
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);


            //encyrpted UN
            byte[] coded = Convert.FromBase64String(trnsUn);
            string code = ASCIIEncoding.ASCII.GetString(coded);
            txtUn.Text = code;
            txtUn.Enabled = false;

        }
        //temporary list
        List<string> values = new List<string>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            //clear list to prevent duplication
            values.Clear();
            //keeps the numbers which is a part of algortm
            int x = 0;
            //pull account names from database add assign them to the list
            SqlCommand cmd = new SqlCommand("select AccountName from Tbl_Account where UserId=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                values.Add(dr[0].ToString().Trim());
            }
            //check if there is alreday taken one we have
            for (int i = 0; i < values.Count; i++)
            {
                if (txtAccName.Text == values[i].ToString().Trim())
                {
                    x++;
                }
            }
            //if there is one , gives error message
            if (x > 0)
            {
                MessageBox.Show("You already Have this Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccName.Text = "";
                txtAccName.Focus();
            }
            else
            {   //if it is not empty, tries to save it
                if (txtAccName.Text != string.Empty)
                {
                    //Pull account infrmations and write it
                    SqlCommand cmd2 = new SqlCommand("Insert into Tbl_Account (AccountName,UserId) values (@p1,@p2)",conn.connection());
                    cmd2.Parameters.AddWithValue("@p1",txtAccName.Text);
                    cmd2.Parameters.AddWithValue("@p2", trnsId);
                    cmd2.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show("Account Has been Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccName.Text = "";

                }
                else
                {
                    //if it not error message
                    MessageBox.Show("Please Provide An Account Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //leads you to go back
            frmAccountSettings fr = new frmAccountSettings();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Close();
        }
    }
}
