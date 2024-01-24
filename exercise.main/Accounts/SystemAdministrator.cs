using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Accounts
{
    public class SystemAdministrator : Account
    {

        public SystemAdministrator(string email, string password) : base(email, password)
        {
        }

        public override bool IsEnabled() { return true; }

        public override bool CanLogIn() { return true; }
    }
}
