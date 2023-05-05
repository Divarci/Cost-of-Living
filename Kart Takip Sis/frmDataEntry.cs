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

        sql conn = new sql();

        int DataId;

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        public string TempAccId, TempAccName;

        void ListAll()
        {
            //listAll from sql 
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Database where UserId=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grpInfo.Text = "All Accounts";

            //datagridview specifications
            dgwDataEntry.DataSource = dt;
            dgwDataEntry.Columns[0].Visible = false;
            dgwDataEntry.Columns[1].Visible = false;
            dgwDataEntry.Columns[2].Visible = false;
            dgwDataEntry.Columns[6].Visible = false;
            dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        void ListFiltered()
        {
            //list from sql
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Database where UserId=@p1 and AccountId=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", cmbAcc.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //selects account name with a method
            grpInfo.Text = cmbAcc.SelectedText;

            //datagridview specifications
            dgwDataEntry.DataSource = dt;
            dgwDataEntry.Columns[0].Visible = false;
            dgwDataEntry.Columns[1].Visible = false;
            dgwDataEntry.Columns[2].Visible = false;
            dgwDataEntry.Columns[6].Visible = false;
            dgwDataEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void cleanit()
        {
            //clean forms
            mskDate.Text = "";
            txtComp.Text = "";
            rchDesc.Text = "";
            mskAmount.Text = "";
            //radia button default
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
               
        //radio button results assigned to variabiles which is used to understand if the amount is expense or income
        RadioButton tempRadioButton = new RadioButton();
        int expOrInc = 0;
        void RadioBtnCheck()
        {
            if (rdexp.Checked)
            {
                tempRadioButton.Checked = false;
                //assigned to make amount deciding expense or income
                expOrInc = -1;
            }
            else if (rdinc.Checked)
            {
                tempRadioButton.Checked = true;
                //assigned to make amount deciding expense or income

                expOrInc = 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //radio button assigns for crud operation
            RadioBtnCheck();

            //update data
            SqlCommand cmd = new SqlCommand("Update Tbl_Database set AccountId=@p1,Date=@p2,Company=@p3,Description=@p4,[Exp/Inc]=@p5,Amount=@p6 where DataId=@p7 ", conn.connection());
            cmd.Parameters.AddWithValue("@p1", cmbAcc.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", mskDate.Text);
            cmd.Parameters.AddWithValue("@p3", txtComp.Text);
            cmd.Parameters.AddWithValue("@p4", rchDesc.Text);
            cmd.Parameters.AddWithValue("@p5", tempRadioButton.Checked);
            cmd.Parameters.AddWithValue("@p6", expOrInc * Convert.ToInt32(mskAmount.Text));
            cmd.Parameters.AddWithValue("@p7", DataId);
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            //gives us message
            MessageBox.Show("Data has been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //list current datas
            ListFiltered();
            //clean forms
            cleanit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Database where DataId=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", DataId);
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            //gives us message
            MessageBox.Show("Data has been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //list current datas
            ListAll();
        }

        private void dgwDataEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selects clicked dataid for crud operations
            int choosen;
            choosen = dgwDataEntry.SelectedCells[0].RowIndex;
            DataId = Convert.ToInt16(dgwDataEntry.Rows[choosen].Cells[0].Value);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search button algortim
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
            //leads main menu
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
            //clean all forms
            cmbSearch.Text = "";
            txtSearch.Text = "";
            cleanit();
            ListAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //radio button assigns for crud operation
            RadioBtnCheck();

            //insert data
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Database (UserId,AccountId,Date,Company,Description,[Exp/Inc],Amount) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", cmbAcc.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", mskDate.Text);
            cmd.Parameters.AddWithValue("@p4", txtComp.Text);
            cmd.Parameters.AddWithValue("@p5", rchDesc.Text);
            cmd.Parameters.AddWithValue("@p6", tempRadioButton.Checked);
            cmd.Parameters.AddWithValue("@p7", expOrInc * (Convert.ToDecimal(mskAmount.Text)));

            cmd.ExecuteNonQuery();
            conn.connection().Close();

            MessageBox.Show("Data has been Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListFiltered();
            cleanit();
        }

        private void dgwDataEntry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //assing selected data to forms to update
            int choosen = dgwDataEntry.SelectedCells[0].RowIndex;
            string TempString;

            TempString = dgwDataEntry.Rows[choosen].Cells[2].Value.ToString();
            SqlCommand cmd = new SqlCommand("Select AccountName from Tbl_Account where UserId=@p1 and AccountId=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            cmd.Parameters.AddWithValue("@p2", TempString);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TempAccName = (reader[0].ToString());
            }
            DataId = Convert.ToInt32(dgwDataEntry.Rows[choosen].Cells[0].Value);
            mskDate.Text = dgwDataEntry.Rows[choosen].Cells[3].Value.ToString();
            txtComp.Text = dgwDataEntry.Rows[choosen].Cells[4].Value.ToString();
            rchDesc.Text = dgwDataEntry.Rows[choosen].Cells[5].Value.ToString();
            mskAmount.Text = dgwDataEntry.Rows[choosen].Cells[7].Value.ToString();
            
            //assign radio button value
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
            //bring a list according to selected account
            ListFiltered();

        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {

            //assign account information to combobox
            SqlCommand cmd = new SqlCommand("Select AccountName,AccountId from Tbl_Account where UserId=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", trnsId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbAcc.ValueMember = "AccountId";
            cmbAcc.DisplayMember = "AccountName";
            cmbAcc.DataSource = dt;

            cmbAcc.Text = "";




            //button colour
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnDelete, Color.HotPink, Color.HotPink, Color.HotPink);
            btncolor.btnclr(btnUpdate, Color.Violet, Color.Violet, Color.Violet);
            btncolor.btnclr(btnSave, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnSearch, Color.Turquoise, Color.Turquoise, Color.Turquoise);
            btncolor.btnclr(btnUserMenu, Color.Tomato, Color.Tomato, Color.Tomato);

            //list method
            ListAll();
        }
    }
}
