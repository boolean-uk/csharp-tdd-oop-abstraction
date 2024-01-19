using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class Accounts
    {
        private List<Account> accounts;

        public Accounts()
        {
            accounts = new List<Account>();
        }

        public void Add(Account account)
        {
            accounts.Add(account);
        }

        public Account Get(string email)
        {
            return accounts[accounts.FindIndex(a => a.Email == email)];
        }

        public List<Account> AccountList { get => accounts; set => accounts = value; }


    }
}
