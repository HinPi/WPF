using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class UserRecieveDAL
    {
        public DataSet GetAllRecieveDAL()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from recievedusers", conn);
            DataSet ds = new DataSet("recieved");
            da.Fill(ds);
            return ds;
        }

        public DataSet GetAllRecieveUserDAL(int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter($"select bookid, bookname, daterecieved from recievedusers where iduser={userId}", conn);
            DataSet ds = new DataSet("userrecieved");
            da.Fill(ds);
            return ds;
        }

        public bool AddRecieveDAL(int bookId, string bookName, int userId, string userName)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "insert into recievedusers(bookid, bookname, date, userid, username) value(@bookid, @bookname, @date, @userid, @username)",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@bookid", bookId));
            cmd.Parameters.Add(new MySqlParameter("@bookname", bookName));
            cmd.Parameters.Add(new MySqlParameter("@date", DateTime.Now.Date));
            cmd.Parameters.Add(new MySqlParameter("@userid", userId));
            cmd.Parameters.Add(new MySqlParameter("@username", userName));

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
        
        public bool DeleteRecieveDAL(int bookId, int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "delete top(1) from recievedusers where bookid=@bookid and userid=@userid",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@bookid", bookId));
            cmd.Parameters.Add(new MySqlParameter("@userid", userId));

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
    }
}
