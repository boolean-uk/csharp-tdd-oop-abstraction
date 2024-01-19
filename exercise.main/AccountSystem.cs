using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AccountSystem
    {
        private List<Account> _accounts = new List<Account>();
        public bool CreateAccount(string email, string password)
        {
            Account account = new Account(email, password);

            bool validPassword = account.HasValidPassword();
            bool validEmail = account.HasValidEmail();

            if (!validPassword || !validEmail) return false;
            _accounts.Add(account);
            return true;
        }

        public void ToggleAccount(Account account)
        {
            account.Toggle();
        }
    }
}
