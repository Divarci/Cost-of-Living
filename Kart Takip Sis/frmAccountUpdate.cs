using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmAccountUpdate : Form
    {
        public frmAccountUpdate()
        {
            InitializeComponent();
        }
        //sql connection
        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void frmAccountUpdate_Load(object sender, EventArgs e)
        {
            //button colour
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

            byte[] coded = Convert.FromBase64String(trnsUn);
            string code = ASCIIEncoding.ASCII.GetString(coded);

            txtUn.Text = code;
            txtUn.Enabled = false;

            //add account names in combobox
            SqlCommand cmd2 = new SqlCommand("select AccountName from Tbl_Account where UserId=@p1", conn.connection());
            cmd2.Parameters.AddWithValue("@p1", trnsId);
            SqlDataReader rdr = cmd2.ExecuteReader();
            while (rdr.Read())
            {
                cmbAcc.Items.Add(rdr[0].ToString().Trim());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this is an algoritm if typed one is same one of existing account nname x++
            int x = 0;

            for (int i = 0; i < cmbAcc.Items.Count; i++)
            {
                if (txtNewAcc.Text == cmbAcc.Items[i].ToString().Trim())
                {
                    x++;
                }
            }

            //it means typed accunt name is already taken
            if (x > 0)
            {
                MessageBox.Show("You already Have this Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewAcc.Text = "";
                txtNewAcc.Focus();
            }
            //if it is not first check boxes are not empty
            else
            {
                if (txtNewAcc.Text == string.Empty || cmbAcc.Text == string.Empty)
                {
                    MessageBox.Show("Please provide all Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewAcc.Text = "";
                    cmbAcc.Text = "";
                    txtNewAcc.Focus();
                }
                //if it is not add account name to database
                else
                {
                    SqlCommand cmd = new SqlCommand("Update Tbl_Account set AccountName=@p1 where AccountName=@p3 and UserId=@p2", conn.connection());
                    cmd.Parameters.AddWithValue("@p1",txtNewAcc.Text);
                    cmd.Parameters.AddWithValue("@p2",trnsId);
                    cmd.Parameters.AddWithValue("@p3",cmbAcc.Text);
                    cmd.ExecuteNonQuery();
                    conn.connection().Close();

                    MessageBox.Show("Account has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear forms for new record
                    txtNewAcc.Text = "";
                    cmbAcc.Text = "";
                    txtNewAcc.Focus();

                    //Clear combo box as accounts updated
                    cmbAcc.Items.Clear();

                    //combobox updated with new values
                    SqlCommand cmd2 = new SqlCommand("select AccountName from Tbl_Account where UserId=@p1", conn.connection());
                    cmd2.Parameters.AddWithValue("@p1", trnsId);
                    SqlDataReader rdr = cmd2.ExecuteReader();
                    while (rdr.Read())
                    {
                        cmbAcc.Items.Add(rdr[0].ToString());
                    }

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Leads you to Account Settings
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
