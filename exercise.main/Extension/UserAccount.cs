using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class UserAccount : Account
    {
        private bool isEnabled;

        public UserAccount(string email, string password) : base(email, password)
        {
        }

        public void Enable(Login login)
        {
            if (login.IsAdmin()) isEnabled = true;
            else throw new UnauthorizedAccessException("Illegal operation.");
        }

        public void Disable(Login login)
        {
            if (login.IsAdmin()) isEnabled = false;
            else throw new UnauthorizedAccessException("Illegal operation.");
        }

        public bool IsEnabled { get => isEnabled;}
    }
}
