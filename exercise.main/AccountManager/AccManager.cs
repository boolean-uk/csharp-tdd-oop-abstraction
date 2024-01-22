using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.AccountManager
{
    public class AccManager
    {
        public AccManager() { }
        public List<Account> accounts = new List<Account>();

        public string CreateAccount(string email, string password)
        {
            if(!email.Contains("@"))
            {
                return "Wrong email"; 
            }
           

            if(password.Count() < 8) 
            { 
                return "Wrong password"; 
            }

            accounts.Add(new Account(email, password));
            return "Account created";
        }
    }
}
