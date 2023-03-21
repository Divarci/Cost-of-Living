using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmUserSettings : Form
    {
        public frmUserSettings()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdateUser(txtUn.Text,txtPass.Text,txtName.Text,txtSurname.Text,trnsId);
            MessageBox.Show("User has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmSignInMainMenu fr = new frmSignInMainMenu();
            
            fr.trnsName = txtName.Text;
            fr.trnsUn = txtUn.Text;
            fr.trnsPass = txtPass.Text;
            fr.trnsSurname = txtSurname.Text;
            
            fr.Show();
            this.Hide();
        }

       
        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

            txtUn.Text = trnsUn;
            txtPass.Text = trnsPass;
            txtName.Text = trnsName;
            txtSurname.Text = trnsSurname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
