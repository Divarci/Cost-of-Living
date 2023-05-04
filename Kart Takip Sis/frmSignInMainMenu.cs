using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmSignInMainMenu : Form
    {
        public frmSignInMainMenu()
        {
            InitializeComponent();
        }
        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void frmSignInMainMenu_Load(object sender, EventArgs e)
        {
            //encrypted username
            byte[] coded = Convert.FromBase64String(trnsUn);
            string code = ASCIIEncoding.ASCII.GetString(coded);

            grpInfo.Text = code;

            //button color 
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnAccount, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);
            btncolor.btnclr(btnDataEntry, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnReport, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnUserSettings, Color.HotPink, Color.HotPink, Color.HotPink);
            btncolor.btnclr(btnToDoList, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnSwitchUser, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);

            //Assign name and surname to labels
            lblName.Text = trnsName;
            lblSurname.Text = trnsSurname;

            //count your account nuber and assign it to a label
            SqlCommand cmd = new SqlCommand("Select Count(AccountName) from Tbl_Account where UserId=@p1",conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAccount.Text = dr[0].ToString();
            }
            conn.connection().Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //leads you to account settings
            frmAccountSettings fr = new frmAccountSettings();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            //leads you to account settings
            frmLogin fr = new frmLogin();
            //fr.trnsId = trnsId;
            //fr.trnsName = trnsName;
            //fr.trnsUn = trnsUn;
            //fr.trnsPass = trnsPass;
            //fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //directs you to report page
            frmReport fr = new frmReport();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            //directs you to User Settings page
            frmUserSettings fr = new frmUserSettings();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {
            //close application

            Application.Exit();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            //If we dont have any account. it asks us to have one once
            if (Convert.ToInt16(lblAccount.Text) <= 0)
            {
                MessageBox.Show("Please ADD a new Account First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                //if we have lts us to enter dataentry page
                frmDataEntry fr = new frmDataEntry();
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
}
