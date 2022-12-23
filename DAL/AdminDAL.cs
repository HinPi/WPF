using MySql.Data.MySqlClient;
namespace DAL
{
    public class AdminDAL
    {
        public bool AdminLoginDAL(string email, string pass)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand($"select count(*) from admins where adminemail='{email}' and adminpass='{pass}'", conn);

            conn.Open();
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (res != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
