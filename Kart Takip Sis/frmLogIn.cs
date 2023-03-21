using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Kart_Takip_Sis
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("Select UserName,Password from Tbl_Users where UserName=@p1 and Password=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", txtUn.Text);
            cmd.Parameters.AddWithValue("@p2", txtPass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtUn.Text = dr[0].ToString();
                txtPass.Text = dr[1].ToString();

                SqlCommand cmd2 = new SqlCommand("Select Name,Surname,UserId from Tbl_Users where Username=@p1 and Password=@p2", conn.connection());
                cmd2.Parameters.AddWithValue("@p1", txtUn.Text);
                cmd2.Parameters.AddWithValue("@p2", txtPass.Text);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    trnsName = dr2[0].ToString();
                    trnsSurname = dr2[1].ToString();
                    trnsId = Convert.ToInt16(dr2[2].ToString());
                }

                conn.connection().Close();
                trnsUn = txtUn.Text;
                trnsPass = txtPass.Text;

                frmSignInMainMenu fr = new frmSignInMainMenu();

                fr.trnsId = trnsId;
                fr.trnsName = trnsName;
                fr.trnsUn = trnsUn;
                fr.trnsPass = trnsPass;
                fr.trnsSurname = trnsSurname;

                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or Password is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnSignIn, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnSu, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);

        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            frmSignUp fr = new frmSignUp();
            fr.Show();
            this.Hide();

        }
    }
}
