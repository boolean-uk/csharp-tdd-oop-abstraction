using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Extension
    {
        public class UserAccount
        {
            private string _email;
            private string _password;
            private bool _isEnabled;

            public UserAccount(string email, string password)
            {
                _email = email;
                _password = password;
                _isEnabled = false; 
            }

            private bool IsValidEmail(string email)
            {
                throw new NotImplementedException();
            }

            private bool IsValidPassword(string password)
            {
                throw new NotImplementedException();
            }

            public void EnableAccount()
            {
                throw new NotImplementedException();
            }

            public bool CanLogin()
            {
                throw new NotImplementedException();
            }
        }
    }
}
