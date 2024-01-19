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
            throw new NotImplementedException();
        }

        public void Enable(Login login)
        {
            throw new NotImplementedException();
        }

        public void Disable(Login login)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled { get => isEnabled;}
    }
}
