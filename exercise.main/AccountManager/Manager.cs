using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.AccountManager
{
    public class Manager : IUserOps
    {
        public void EnableAccount(Account account)
        {
            account.EnableAccount(true);
        }
    }
}

