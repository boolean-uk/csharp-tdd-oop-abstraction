using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AccountRegister
    {
        private List<UserAccount> _users;
        private AdminAccount _admin; 

        public AccountRegister()
        {
            _users = new List<UserAccount>();
            _admin = new AdminAccount();
        }

        public string CreateUser(string email, string password)
        {
            if(!email.Contains('@'))
            {
                return "Invalid email"; 
            }
            else if (password.Length < 8)
            {
                return "Invalid password"; 
            }
            else
            {
                _users.Add(new UserAccount(email, password));
                return "New user was successfully created"; 
            }
        }

        public string CheckIfUserCanLogin(string email)
        {
            UserAccount user = _users.FirstOrDefault(u => u.GetEmail() == email);

            if (user != null && user.CanUserLogin())
            {
                return "User can log in";
            }
            else
            {
                return "User cannot log in";
            }
        }
    }
}
