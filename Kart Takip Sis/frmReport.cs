using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kart_Takip_Sis
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId, x;

        private void btnCompRep_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("Select Sum(Amount) from Tbl_Database where UserId=@p1 and Company=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", cmbComp.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblComp.Text = dr[0].ToString();

            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
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

        string TempAccId, TempAccName;

        private void btnAccRep_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select AccountId from Tbl_Account where UserId=@p1 and AccountName=@p2", conn.connection());
            cmd2.Parameters.AddWithValue("@p1", trnsId);
            cmd2.Parameters.AddWithValue("@p2", cmbAcc.Text);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                TempAccId = reader[0].ToString();
            }

            SqlCommand cmd = new SqlCommand("Select Sum(Amount) from Tbl_Database where UserId=@p1 and AccountId=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", Convert.ToInt16(TempAccId));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAcc.Text = dr[0].ToString();

            }

        }



        private void frmReport_Load(object sender, EventArgs e)
        {
            frmDataEntry fr = new frmDataEntry();
            fr.fillCmbBox(trnsId, cmbAcc);

            SqlCommand cmd2 = new SqlCommand("Select DISTINCT Company from Tbl_Database  where UserId=@p1", conn.connection());
            cmd2.Parameters.AddWithValue("@p1", trnsId);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                cmbComp.Items.Add(reader[0].ToString());
            }

            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnCompRep, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnAccRep, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnCancel, Color.HotPink, Color.HotPink, Color.HotPink);
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
