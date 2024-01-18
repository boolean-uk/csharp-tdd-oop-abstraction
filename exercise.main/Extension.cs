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
                if (!IsValidEmail(email))
                    throw new ArgumentException("Invalid email");

                if (!IsValidPassword(password))
                    throw new ArgumentException("Invalid password");

                _email = email;
                _password = password;
                _isEnabled = false;
            }

            private bool IsValidEmail(string email)
            {
                return email != null && email.Contains("@");
            }

            private bool IsValidPassword(string password)
            {
                return password != null && password.Length >= 8;
            }

            public void EnableAccount()
            {
                _isEnabled = true;
            }

            public bool CanLogin()
            {
                return _isEnabled;
            }
        }

    }
}
