using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmAccountSettings : Form
    {
        public frmAccountSettings()
        {
            InitializeComponent();
        }

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            //button colour 
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnAccUp, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnNewAcc, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);
        }
        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            //directs us to new account page
            frmNewAccount fr = new frmNewAccount();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }
        private void btnAccUp_Click(object sender, EventArgs e)
        {
            //directs us to update account page
            frmAccountUpdate fr = new frmAccountUpdate();
            fr.trnsId = trnsId;
            fr.trnsName = trnsName;
            fr.trnsUn = trnsUn;
            fr.trnsPass = trnsPass;
            fr.trnsSurname = trnsSurname;
            fr.Show();
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //directs us to go back
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
