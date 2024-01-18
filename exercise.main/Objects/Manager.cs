using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Objects
{
    public class Manager : IUserOperations
    {
        public void EnableAccount(AccountObj account)
        {
            account.EnableAccount(true);
        }
    }
}
