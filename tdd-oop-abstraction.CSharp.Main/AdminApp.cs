using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class AdminApp
    {
        List<Account> _accounts = new List<Account>();


        public string CreateAccount(string email, string password)
        {
            return "";
        }

        public void SetEnabledAccount(string email)
        {

        }

        public bool IsEnabledAccount(string email)
        {
            return true;
        }
    }
}