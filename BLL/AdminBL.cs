using DAL;

namespace BLL
{
    public class AdminBL
    {
        public bool AdminLoginBL(string adminEmail, string adminPass)
        {
            AdminDAL adminDal = new AdminDAL();
            bool isDone = adminDal.AdminLoginDAL(adminEmail, adminPass);
            return isDone;
        }
    }
}
