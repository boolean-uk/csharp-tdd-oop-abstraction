using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.AccountManager
{
    public interface IUserOps
    {
        void EnableAccount(Account account) { }
    }
}
