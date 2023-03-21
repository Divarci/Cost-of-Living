using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    public partial class frmDataEntry : Form
    {
        public frmDataEntry()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        sql conn = new sql();

        int DataId;

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        public string TempAccId, TempAccName;
        RadioButton x = new RadioButton();
        int y = 0;

        void listbaby()
        {
            if (cmbAcc.Text == "All Accounts" || cmbAcc.Text == string.Empty)
            {
                /*
                dgwDataEntry.DataSource = ds.Listit(grptemp6);

                dgwDataEntry.Columns[7].Visible = false;
                dgwDataEntry.Columns[8].Visible = false;
                dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                */
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Database where UserId=@p1", conn.connection());
                //SqlCommand cmd = new SqlCommand("select Tbl_Database.Date,Tbl_Account.AccountName from Tbl_Database INNER JOIN Tbl_Account ON Tbl_Database.AccountId = Tbl_Account.AccountId where Tbl_Database.UserId=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", trnsId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                grpInfo.Text = "All Accounts";
                dgwDataEntry.DataSource = dt;
                dgwDataEntry.Columns[0].Visible = false;
                dgwDataEntry.Columns[1].Visible = false;
                dgwDataEntry.Columns[2].Visible = false;
                dgwDataEntry.Columns[6].Visible = false;
                dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            else
            {/*
                dgwDataEntry.DataSource = ds.ListbyAcc(grptemp6, cmbAcc.Text);
                accounId();

                dgwDataEntry.Columns[7].Visible = false;
                dgwDataEntry.Columns[8].Visible = false;
                dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/
                accounId();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Database where UserId=@p1 and AccountId=@p2", conn.connection());
                cmd.Parameters.AddWithValue("@p1", trnsId);
                cmd.Parameters.AddWithValue("@p2", Convert.ToInt16(TempAccId));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                accountname(TempAccId);
                grpInfo.Text = TempAccName;
                dgwDataEntry.DataSource = dt;
                dgwDataEntry.Columns[0].Visible = false;
                dgwDataEntry.Columns[1].Visible = false;
                dgwDataEntry.Columns[2].Visible = false;
                dgwDataEntry.Columns[6].Visible = false;
                dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        void cleanit()
        {
            //cmbAcc.Text = "All Account";
            mskDate.Text = "";
            txtComp.Text = "";
            rchDesc.Text = "";
            mskAmount.Text = "";
            if (rdexp.Checked)
            {
                rdexp.Checked = false;
            }
            else if (rdinc.Checked)
            {
                rdinc.Checked = false;
            }
            cmbAcc.Focus();
        }

        public void accounId()
        {
            SqlCommand cmd = new SqlCommand("Select AccountId from Tbl_Account where UserId=@p1 and AccountName=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", cmbAcc.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TempAccId = (reader[0].ToString());
            }
        }
        public void accountname(string AccId)
        {
            SqlCommand cmd = new SqlCommand("Select AccountName from Tbl_Account where UserId=@p1 and AccountId=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", AccId);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TempAccName = (reader[0].ToString());
            }
        }
        void RadioBtnCheck()
        {

            if (rdexp.Checked)
            {
                x.Checked = false;
                y = -1;
            }
            else if (rdinc.Checked)
            {
                x.Checked = true;
                y = 1;
            }
        }

        public void fillCmbBox(int userid, ComboBox cmb)
        {

            SqlCommand cmd = new SqlCommand("Select AccountName from Tbl_Account where UserId=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", userid);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb.Items.Add(reader[0].ToString());
            }
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RadioBtnCheck();
            accounId();
            /*
            ds.DataUpdate(Convert.ToInt16(TempAccId), mskDate.Text, txtComp.Text, rchDesc.Text, x.Checked, y * Convert.ToInt16(mskAmount.Text), Convert.ToInt16(DataId));
            MessageBox.Show("Data has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */

            SqlCommand cmd = new SqlCommand("Update Tbl_Database set AccountId=@p1,Date=@p2,Company=@p3,Description=@p4,[Exp/Inc]=@p5,Amount=@p6 where DataId=@p7 ", conn.connection());
            cmd.Parameters.AddWithValue("@p1", TempAccId);
            cmd.Parameters.AddWithValue("@p2", mskDate.Text);
            cmd.Parameters.AddWithValue("@p3", txtComp.Text);
            cmd.Parameters.AddWithValue("@p4", rchDesc.Text);
            cmd.Parameters.AddWithValue("@p5", x.Checked);
            cmd.Parameters.AddWithValue("@p6", y * Convert.ToInt32(mskAmount.Text));
            cmd.Parameters.AddWithValue("@p7", DataId);
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Data has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listbaby();
            cleanit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds.DeleteData(DataId);
            MessageBox.Show("Data has been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listbaby();
        }

        private void dgwDataEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen;
            choosen = dgwDataEntry.SelectedCells[0].RowIndex;
            DataId = Convert.ToInt16(dgwDataEntry.Rows[choosen].Cells[0].Value);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cleanit();
            if (cmbSearch.Text == "Company")
            {
                SqlCommand sql = new SqlCommand("SELECT Date,Company,Description,Amount from Tbl_Database Where UserId=@p1 and Company like '%" + txtSearch.Text + "%'", conn.connection());
                sql.Parameters.AddWithValue("@p1", trnsId);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                dgwDataEntry.DataSource = dt;
            }
            else if (cmbSearch.Text == "Description")
            {
                SqlCommand sql = new SqlCommand("SELECT Date,Company,Description,Amount from Tbl_Database Where UserId=@p1 and Description like '%" + txtSearch.Text + "%'", conn.connection());
                sql.Parameters.AddWithValue("@p1", trnsId);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                dgwDataEntry.DataSource = dt;
            }
            else if (cmbSearch.Text == "Amount")
            {
                SqlCommand sql = new SqlCommand("SELECT Date,Company,Description,Amount from Tbl_Database Where UserId=@p1 and Amount like '%" + txtSearch.Text + "%'", conn.connection());
                sql.Parameters.AddWithValue("@p1", trnsId);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                dgwDataEntry.DataSource = dt;
            }
            else if (cmbSearch.Text == "Date")
            {
                SqlCommand sql = new SqlCommand("SELECT Date,Company,Description,Amount from Tbl_Database Where UserId=@p1 and Date like '%" + txtSearch.Text + "%'", conn.connection());
                sql.Parameters.AddWithValue("@p1", trnsId);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                dgwDataEntry.DataSource = dt;
            }
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            cmbSearch.Text = "";
            txtSearch.Text = "";
            cleanit();
            listbaby();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            ds.DataAdd(short.Parse(UserIdDentry), short.Parse(TempAccId), mskDate.Text, txtComp.Text, rchDesc.Text, x.Checked, y * Convert.ToInt16(mskAmount.Text));
            */

            RadioBtnCheck();
            accounId();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Database (UserId,AccountId,Date,Company,Description,[Exp/Inc],Amount) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", short.Parse(TempAccId));
            cmd.Parameters.AddWithValue("@p3", mskDate.Text);
            cmd.Parameters.AddWithValue("@p4", txtComp.Text);
            cmd.Parameters.AddWithValue("@p5", rchDesc.Text);
            cmd.Parameters.AddWithValue("@p6", x.Checked);
            cmd.Parameters.AddWithValue("@p7", y * (Convert.ToDecimal (mskAmount.Text)));

            cmd.ExecuteNonQuery();
            conn.connection().Close();

            MessageBox.Show("Data has been Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listbaby();
            cleanit();
        }

        private void dgwDataEntry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dgwDataEntry.SelectedCells[0].RowIndex;
            string TempString;

            TempString = dgwDataEntry.Rows[choosen].Cells[2].Value.ToString();
            accountname(TempString);
            DataId = Convert.ToInt32(dgwDataEntry.Rows[choosen].Cells[0].Value);
            mskDate.Text = dgwDataEntry.Rows[choosen].Cells[3].Value.ToString();
            txtComp.Text = dgwDataEntry.Rows[choosen].Cells[4].Value.ToString();
            rchDesc.Text = dgwDataEntry.Rows[choosen].Cells[5].Value.ToString();
            mskAmount.Text = dgwDataEntry.Rows[choosen].Cells[7].Value.ToString();


            if (dgwDataEntry.Rows[choosen].Cells[6].Value.ToString().Trim() == "False")
            {
                rdexp.Checked = true;
            }
            else
            {
                rdinc.Checked = true;
            }
            cmbAcc.Text = TempAccName;
        }

        private void cmbAcc_SelectedIndexChanged(object sender, EventArgs e)
        {

            listbaby();

        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {
            fillCmbBox(trnsId, cmbAcc);



            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnDelete, Color.HotPink, Color.HotPink, Color.HotPink);
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnSearch, Color.Turquoise, Color.Turquoise, Color.Turquoise);
            btncolor.btnclr(btnUserMenu, Color.Tomato, Color.Tomato, Color.Tomato);

            listbaby();
        }
    }
}
