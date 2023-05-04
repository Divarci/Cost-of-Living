using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
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
        //sql connection
        sql conn = new sql();

        public string trnsName, trnsSurname, trnsUn, trnsPass;
        public int trnsId;

        //Pass show
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
        //Pass hide
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //username and password cyrpted
            byte[] text1 = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
            string text2 = Convert.ToBase64String(text1);

            byte[] text3 = ASCIIEncoding.ASCII.GetBytes(txtUn.Text);
            string text4 = Convert.ToBase64String(text3);

            //Login check
            SqlCommand cmd = new SqlCommand("Select UserName,Password,Name,Surname,UserId from Tbl_Users where UserName=@p1 and Password=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", text4);
            cmd.Parameters.AddWithValue("@p2", text2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                text4 = dr[0].ToString();
                text2 = dr[1].ToString();

                // if login happens, datas will be transferred to main page
                SqlCommand cmd2 = new SqlCommand("Select UserName,Password,Name,Surname,UserId from Tbl_Users where UserName=@p1 and Password=@p2", conn.connection());
                cmd2.Parameters.AddWithValue("@p1", text4);
                cmd2.Parameters.AddWithValue("@p2", text2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    trnsUn = dr2[0].ToString();
                    trnsPass = dr2[1].ToString();
                    trnsName = dr2[2].ToString();
                    trnsSurname = dr2[3].ToString();
                    trnsId = Convert.ToInt16(dr2[4].ToString());
                }
               
                conn.connection().Close();

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
                // if it is not error message 
                MessageBox.Show("Username or Password is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // button color change
            ButtonColor btncolor = new ButtonColor();

            btncolor.btnclr(btnSignIn, Color.YellowGreen, Color.YellowGreen, Color.YellowGreen);
            btncolor.btnclr(btnSu, Color.LightSeaGreen, Color.LightSeaGreen, Color.LightSeaGreen);

        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            // directs you to signup page
            frmSignUp fr = new frmSignUp();
            fr.Show();
            this.Hide();

        }
    }
}
