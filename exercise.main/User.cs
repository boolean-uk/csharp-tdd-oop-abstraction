using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        /**
         * As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
         * **/
        private string _email;
        private string _password;
        private bool _enabled;

        public User(string email, string password)
        {
            _enabled = false;
            try
            {
                SetEmail(email);
                SetPassword(password);
            }
            catch
            {
                throw;
            }

        }

        public bool Enabled { get => _enabled; }

        public void SetEnabled()
        {
            _enabled = true;
        }

        public void SetDisabled()
        {
            _enabled = false;
        }

        private void SetEmail(string email)
        {
            if (!email.Contains("@")) { throw new Exception("Invalid Email: Please include @"); }
            _email = email;
        }

        private void SetPassword(string password)
        {
            if (password.Length < 8) { throw new Exception("Invalid Password: Minimum of 8 characters required"); }
            _password = password;
        }
    }
}
