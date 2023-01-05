using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class BookDAL
    {
        public DataSet GetAllBooksDAL()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from books", conn);
            DataSet ds = new DataSet("books");
            da.Fill(ds);
            return ds;
        }

        public bool AddBookDAL(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            //string sql = $"insert into books(bookname, bookauthor, bookisbn, bookprice, bookcopies) value('{bookName}', '{bookAuthor}', '{bookISBN}', {bookPrice}, {bookCopies})";
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "insert into books(bookname, bookauthor, bookisbn, bookprice, bookcopies) value(@name, @author, @isbn, @price, @copy)",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@name", bookName));
            cmd.Parameters.Add(new MySqlParameter("@author", bookAuthor));
            cmd.Parameters.Add(new MySqlParameter("@isbn", bookISBN));
            cmd.Parameters.Add(new MySqlParameter("@price", bookPrice));
            cmd.Parameters.Add(new MySqlParameter("@copy", bookCopies));

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

        public bool UpdateBookDAL(int bookId, string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "update books set bookname=@name, bookauthor=@author, bookisbn=@isbn, bookprice=@price, bookcopies=@copy where bookid=@id",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@id", bookId));
            cmd.Parameters.Add(new MySqlParameter("@name", bookName));
            cmd.Parameters.Add(new MySqlParameter("@author", bookAuthor));
            cmd.Parameters.Add(new MySqlParameter("@isbn", bookISBN));
            cmd.Parameters.Add(new MySqlParameter("@price", bookPrice));
            cmd.Parameters.Add(new MySqlParameter("@copy", bookCopies));

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

        public bool DeleteBookDAL(int bookId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=;Charset=utf8");
            MySqlCommand cmd = new MySqlCommand(
                "",
                conn);
            cmd.Parameters.Add(new MySqlParameter("delete from books where bookid=@id", bookId));

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

        public DataSet SearchBookDAL(string keyword)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM `books` WHERE `bookname` OR `bookauthor` LIKE @key",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@key", "%" + keyword + "%"));

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet("books_search");
            da.Fill(ds);
            return ds;
        }

        public bool IncBookCopyDAL(int bookId)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=library_management;password=");
            MySqlCommand cmd = new MySqlCommand(
                "update books set bookcopies=bookcopies+1 where bookid=@id",
                conn);
            cmd.Parameters.Add(new MySqlParameter("@id", bookId));

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
