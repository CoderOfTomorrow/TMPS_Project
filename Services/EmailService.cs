using Bank.Helpers;

namespace Bank.Services
{
    public class EmailService
    {
        private readonly Database database = Database.GetInstance();

        public bool CheckEmail(string email)
        {
            foreach(var obj in database.UserContext)
            {
                if (email == obj.Email)
                    return true;
            }
            return false;
        }
    }
}
