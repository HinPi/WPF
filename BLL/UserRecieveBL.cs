using DAL;
using System.Data;

namespace BLL
{
    public class UserRecieveBL
    {
        public bool AddRecieveBL(int bookId, string bookName, int userId, string userName)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            bool isDone = userRecieveDAL.AddRecieveDAL(bookId, bookName, userId, userName);
            return isDone;
        }

        public DataSet GetAllRecieveDAL()
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            DataSet ds = userRecieveDAL.GetAllRecieveDAL();
            return ds;
        }

        public DataSet GetAllRecieveUserBL(int userId)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            DataSet ds = userRecieveDAL.GetAllRecieveUserDAL(userId);
            return ds;
        }

        public bool DeleteRecieveBL(int bookId, int userId)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            bool isDone = userRecieveDAL.DeleteRecieveDAL(bookId, userId);
            return isDone;
        }
    }
}
