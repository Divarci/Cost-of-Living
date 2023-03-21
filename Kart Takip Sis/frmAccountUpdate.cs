using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmAccountUpdate : Form
    {
        public frmAccountUpdate()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void frmAccountUpdate_Load(object sender, EventArgs e)
        {
            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

            txtUn.Text = trnsUn;
            txtUn.Enabled = false;

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
           
            int x = 0;


            for (int i = 0; i < cmbAcc.Items.Count; i++)
            {
                if (txtNewAcc.Text == cmbAcc.Items[i].ToString().Trim())
                {
                    x++;
                }
            }

            if (x > 0)
            {
                MessageBox.Show("You already Have this Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewAcc.Text = "";
                txtNewAcc.Focus();
            }

            else
            {
                if (txtNewAcc.Text == string.Empty || cmbAcc.Text == string.Empty)
                {
                    MessageBox.Show("Please provide all Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewAcc.Text = "";
                    cmbAcc.Text = "";
                    txtNewAcc.Focus();
                }

                else
                {
                    ds.UpdateAcc(txtNewAcc.Text, Convert.ToByte(trnsId), cmbAcc.Text);
                    MessageBox.Show("Account has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewAcc.Text = "";
                    cmbAcc.Text = "";
                    txtNewAcc.Focus();

                    cmbAcc.Items.Clear();

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
