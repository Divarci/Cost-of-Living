using System;
using System.Data.SqlClient;
using System.Drawing;
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

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        ComboBox tempcmb = new ComboBox();


        private void frmNewAccount_Load(object sender, EventArgs e)
        {


            ButtonColor btncolor = new ButtonColor();
            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);

            txtUn.Text = trnsUn;
            txtUn.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tempcmb.Items.Clear();
            int x = 0;

            SqlCommand cmd3 = new SqlCommand("select AccountName from Tbl_Account where UserId=@p1", conn.connection());
            cmd3.Parameters.AddWithValue("@p1", trnsId);
            SqlDataReader rdr5 = cmd3.ExecuteReader();

            while (rdr5.Read())
            {

                tempcmb.Items.Add(rdr5[0].ToString().Trim());
            }

            for (int i = 0; i < tempcmb.Items.Count; i++)
            {
                if (txtAccName.Text == tempcmb.Items[i].ToString().Trim())
                {
                    x++;
                }
            }

            if (x > 0)
            {
                MessageBox.Show("You already Have this Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccName.Text = "";
                txtAccName.Focus();
            }
            else
            {
                if (txtAccName.Text != string.Empty)
                {

                    ds.AccountAdd(txtAccName.Text, Convert.ToInt16(trnsId));
                    MessageBox.Show("Account Has been Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccName.Text = "";

                }
                else
                {
                    MessageBox.Show("Please Provide An Account Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
