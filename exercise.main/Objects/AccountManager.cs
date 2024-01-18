using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Objects
{
    public class AccountManager
    {
        public AccountManager() { }
        public List<AccountObj> accounts = new();

        public string CreateAccount(string email, string password)
        {
            if (!email.Contains("@")) { return "Wrong email"; }
            if (password.Count() < 8) { return "Wrong password"; }
            accounts.Add(new AccountObj(email, password));
            return "Account created";
        }
    }
}
