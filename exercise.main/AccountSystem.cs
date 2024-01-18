using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AccountSystem
    {
        private List<UserAccount> _users;
        private AdminAccount _adminAccount;

        public AccountSystem()
        {
            _users = new List<UserAccount>();
            _adminAccount = new AdminAccount();
        }

        public string createUser(string email, string password)
        {
            if (!email.Contains("@")) 
            {
                return "invalid email";
            }
            else if (password.Length < 8) 
            {
                return "invalid password";
            }
            _users.Add(new UserAccount(email, password));
            return "new user created";
        }
    }
}
