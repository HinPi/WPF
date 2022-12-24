using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class UserRequestDAL
    {
        public DataSet GetAllRequestDAL()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from requestedusers", conn);
            DataSet ds = new DataSet("requests");
            da.Fill(ds);
            return ds;
        }

        public DataSet GetAllRequestUserDAL(int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter($"select bookid, bookname, daterequested from requestedusers where userid={userId}", conn);
            DataSet ds = new DataSet("usersrequests");
            da.Fill(ds);
            return ds;
        }

        public bool AddRequestDAL(int bookId, string bookName, int userId, string userName)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "insert into requestedusers(bookid, bookname, daterequested, userid, username) value(@bookid, @bookname, @date, @userid, @username)",
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

        public bool DeleteRequestDAL(int bookId, int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "delete from requestedusers where bookid=@bookid and userid=@userid LIMIT 1",
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
