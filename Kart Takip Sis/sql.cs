using System.Data.SqlClient;

namespace Kart_Takip_Sis
{
    internal class sql
    {
        public SqlConnection connection()
        {


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-56RDTT9\SQLDB;Initial Catalog=AccountChase;Integrated Security=True");
            conn.Open();
            return conn;
        }


    }
}
