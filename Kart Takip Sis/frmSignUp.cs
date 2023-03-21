using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }



        sql conn = new sql();

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        ComboBox tempcmb = new ComboBox();

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int x = 0;

            SqlCommand cmd3 = new SqlCommand("select Username from Tbl_Users", conn.connection());
            SqlDataReader rdr5 = cmd3.ExecuteReader();

            while (rdr5.Read())
            {

                tempcmb.Items.Add(rdr5[0].ToString().Trim());
            }

            for (int i = 0; i < tempcmb.Items.Count; i++)
            {
                if (txtUn.Text == tempcmb.Items[i].ToString().Trim())
                {
                    x++;
                }
            }



            if (x > 0)
            {
                MessageBox.Show("This Username hal already Taken. Please choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUn.Focus();
            }

            else if (txtName.Text == string.Empty || txtUn.Text == string.Empty || txtPass.Text == string.Empty || txtSurname.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All Boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ds.UserAdd(txtUn.Text, txtPass.Text, txtName.Text, txtSurname.Text);
                MessageBox.Show("User Has Been Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUn.Text = "";
                txtPass.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                txtUn.Focus();
            }



        }
    }
}
