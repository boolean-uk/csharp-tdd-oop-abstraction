using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Account
    {
        private string _email;
        private string _password;
        private bool _enabled;

        public Account(string email, string password)
        {
            _email = email;
            _password = password;
            _enabled = false;
        }

        public bool CanLogIn()
        {
            return _enabled;
        }

        public void Toggle()
        {
            _enabled = !_enabled;
        }

        internal bool HasValidEmail()
        {
            if (!_email.Contains("@")) Console.WriteLine("Invalid Email");
            return _email.Contains("@");
        }

        internal bool HasValidPassword()
        {
            if (_password.Length < 8) Console.WriteLine("Invalid Password");
            return _password.Length >= 8;
        }
    }
}
