using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class UserDAL
    {
        public DataSet GetAllUsersDAL()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from users", conn);
            DataSet ds = new DataSet("user");
            da.Fill(ds);
            return ds;
        }

        public string AddUserDAL(string userName, int userAdNo, string userEmail, string userPass)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "select count(*) from users where useremail=@email",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@email", userEmail));
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();

            if (count > 0)
            {
                return "User already exists, ";
            }
            else
            {
                MySqlCommand cmd1 = new MySqlCommand(
                    "insert into users(username, useradno, useremail, userpass) value(@name, @adno, @email, @pass)",
                    conn);
                cmd1.Parameters.Add(new MySqlParameter("@name", userName));
                cmd1.Parameters.Add(new MySqlParameter("@adno", userAdNo));
                cmd1.Parameters.Add(new MySqlParameter("@email", userEmail));
                cmd1.Parameters.Add(new MySqlParameter("@pass", userPass));

                conn.Open();
                int res = cmd1.ExecuteNonQuery();
                conn.Close();

                if (res > 0)
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
        }

        public bool UpdateUserDAL(int userId, string userName, int userAdNo, string userEmail, string userPass)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "update users set username=@name, useradno=@adno, useremail=@email, userpass=@pass where userid=@id",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@name", userName));
            cmd.Parameters.Add(new MySqlParameter("@adno", userAdNo));
            cmd.Parameters.Add(new MySqlParameter("@email", userEmail));
            cmd.Parameters.Add(new MySqlParameter("@pass", userPass));

            conn.Open();
            int res = cmd.ExecuteNonQuery();
            conn.Close();

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteUserDAL(int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "delete from users where userid=@id",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@id", userId));

            conn.Open();
            int res = cmd.ExecuteNonQuery();
            conn.Close();

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string TakeUserNameDAL(int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "select username from users where userid=@id",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@id", userId));

            conn.Open();
            string userName = (string)cmd.ExecuteScalar();
            conn.Close();

            return userName;
        }

        public int UserLoginDAL(string userEmail, string userPass)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
                MySqlCommand cmd = new MySqlCommand(
                    "select userid from users where useremail=@email and userpass=@pass",
                    conn);
                cmd.Parameters.Add(new MySqlParameter("@email", userEmail));
                cmd.Parameters.Add(new MySqlParameter("@pass", userPass));

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                conn.Close();
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
