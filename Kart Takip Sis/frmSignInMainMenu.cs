using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
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
        

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void frmSignInMainMenu_Load(object sender, EventArgs e)
        {
            grpInfo.Text = trnsUn;

            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnAccount, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);
            btncolor.btnclr(btnDataEntry, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnReport, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnUserSettings, Color.HotPink, Color.HotPink, Color.HotPink);
            btncolor.btnclr(btnToDoList, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnSwitchUser, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);

            lblName.Text = trnsName;
            lblSurname.Text = trnsSurname;
            lblAccount.Text = ds.CountAccount(trnsUn, trnsPass).ToString();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
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
            frmLogin fr = new frmLogin();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fr = new frmReport();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DENEME");
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(lblAccount.Text) <= 0)
            {
                MessageBox.Show("Please ADD a new Account First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
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
