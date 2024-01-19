using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class ComputerSystem
    {
        private List<Account> _accounts = new List<Account>();
        public List<Account> Accounts { get => _accounts; set => _accounts = value; }

        public ComputerSystem()
        {
            Accounts = new List<Account>();
        }
        public string CreateUserAccount(string email, string password, bool isAdmin = false)
        {
            string message = string.Empty;

            if(!email.Contains('@'))
            {
                message = "Error: Email does not contain an @";
            }

            if(password.Length < 8)
            {
                message = "Error: Password is less than 8 characters";
            }

            if(message == string.Empty)
            {
                Account newAccount;
                if(!isAdmin)
                {
                    newAccount = new User(email, password);
                }
                else
                {
                    newAccount = new Administrator(email, password);
                }
                Accounts.Add(newAccount);
                message = "User successfully created";
            }
            return message;
        }

        public bool LogIn(string email, string password)
        {
            Account foundAccount = Accounts.FirstOrDefault(account => account.Email == email && account.Password == password);

            if(foundAccount != null)
            {
                if (foundAccount.IsEnabled)
                {
                    foundAccount.IsLoggedIn = true;
                    return true;
                }
            }

            return false;
        }
    }
}
