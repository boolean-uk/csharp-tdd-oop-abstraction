using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class Account
    {
        private string? _email;
        private string? _password;
        private bool _isEnabled;

        public Account(string email, string password)
        {
        }

        public bool validateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool validatePassword(string password)
        {
            throw new NotImplementedException();
        }

        public void EnableAccount(Account acc)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsEnabled() { throw new NotImplementedException(); }

        public bool CanLogIn() 
        {
            throw new NotImplementedException();
        }
    }
}
