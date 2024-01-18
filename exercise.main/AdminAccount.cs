using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AdminAccount : BaseAccount
    {
        public AdminAccount(string email ="admin", string password = "admin") : base(email, password)
        {
        }
        public bool EnableAccount(UserAccount account)
        {
            return account.enable();
        }
    }
}
