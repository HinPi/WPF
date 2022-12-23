using DAL;
using System.Data;

namespace BLL
{
    public class UserRequestBL
    {
        public bool AddRequestBL(int bookId, string bookName, int userId)
        {
            UserDAL userDAL = new UserDAL();
            string userName = userDAL.TakeUserNameDAL(userId);
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            bool isDone = userRequestDAL.AddRequestDAL(bookId, bookName, userId, userName);
            return isDone;
        }

        public DataSet GetAllRequestUserBL(int userId)
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            DataSet ds = userRequestDAL.GetAllRequestUserDAL(userId);
            return ds;
        }

        public DataSet GetAllRequestBL()
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            DataSet ds = userRequestDAL.GetAllRequestDAL();
            return ds;
        }

        public bool DeleteRequestBL(int bookId, int userId)
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            bool isDone = userRequestDAL.DeleteRequestDAL(bookId, userId);
            return isDone;
        }
    }
}
