using DAL;
using System.Data;

namespace BLL
{
    public class UserReturnBL
    {
        public bool AddReturnBL(int bookId, string bookName, int userId)
        {
            UserDAL userDAL = new UserDAL();
            string userName = userDAL.TakeUserNameDAL(userId);
            UserReturnDAL userReturnDAL = new UserReturnDAL();
            bool isDone = userReturnDAL.AddReturntDAL(bookId, bookName, userId, userName);
            return isDone;
        }

        public DataSet GetAllReturnBL()
        {
            UserReturnDAL userReturnDAL = new UserReturnDAL();
            DataSet ds = userReturnDAL.GetAllReturnDAL();
            return ds;
        }

        public bool DeleteReturnBL(int bookId, int userId)
        {
            UserReturnDAL userReturnDAL = new UserReturnDAL();
            bool isDone = userReturnDAL.DeleteReturntDAL(bookId, userId);
            return isDone;
        }
    }
}
