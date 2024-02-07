using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _isEnabled;

        public string Email
        {
            get { return _email; }
            set { SetEmail(value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetPassword(value); }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { SetIsEnabled(value); }
        }

        public User(string email, string password)
        {
           _email = email;
            _password = password;
            _isEnabled = false;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        public void SetEmail(string email)
        {
            if (IsValidEmail(email))
            {
                _email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email");
            }
        }

        public void SetPassword(string password)
        {
            if (IsValidPassword(password))
            {
                _password = password;
            }
            else
            {
                throw new ArgumentException("Password should be at least 8 characters long");
            }
        }

        public void SetIsEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
        }

        public string IsAbleToLogin() => IsEnabled ? "You're able to login" : "You're not able to login";
    }

}
