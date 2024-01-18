using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class Administrator : User
    {
        public void EnableAccount(Account account)
        {
            account.IsEnabled = true;
        }
    }
}
