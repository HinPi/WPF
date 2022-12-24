using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class UserReturnDAL
    {
        public DataSet GetAllReturnDAL()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from returnedusers", conn);
            DataSet ds = new DataSet("returns");
            da.Fill(ds);
            return ds;
        }

        public DataSet GetAlllReturnUserDAL(int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter($"select bookid, bookname, daterecieved from returnedusers where iduser={userId}", conn);
            DataSet ds = new DataSet("usersreturns");
            da.Fill(ds);
            return ds;
        }

        public bool AddReturntDAL(int bookId, string bookName, int userId, string userName)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "insert into returnedusers(bookid, bookname, datereturned, userid, username) value(@bookid, @bookname, @date, @userid, @username)",
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

        public bool DeleteReturntDAL(int bookId, int userId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "delete from returnedusers where bookid=@bookid and userid=@userid limit 1",
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
