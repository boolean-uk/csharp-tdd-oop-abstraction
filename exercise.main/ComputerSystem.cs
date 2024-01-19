using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class ComputerSystem
    {
        private List<Account> _accounts;
        public List<Account> Accounts { get; set; }

        public string CreateUserAccount(string email, string password, bool isAdmin = false)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
