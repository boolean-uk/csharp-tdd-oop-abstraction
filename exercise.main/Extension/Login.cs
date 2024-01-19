using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class Login
    {
        private Account account;

        public Login(Account account, string password)
        {
            LogIn(account, password);
        }

        public void LogIn(Account account, string password)
        {
            if (account.IsCorrectPassword(password))
            {
                if (account is UserAccount && !(account as UserAccount).IsEnabled)
                {
                    throw new InvalidOperationException("Your account is not enabled.");
                }
                this.account = account;

            }
            else throw new InvalidOperationException("Invalid username or password.");
        }

        public bool IsAdmin()
        {
            return account is AdminAccount;
        }
    }
}
