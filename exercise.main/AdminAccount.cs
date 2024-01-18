using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AdminAccount : BaseAccount
    {
        public AdminAccount(string email = "admin",  string password = "pass") : base(email, password) 
        {
        }

        public bool EnableUserAccount(UserAccount userAccount)
        {
            return userAccount.EnableLogin();
        }
    }
}
