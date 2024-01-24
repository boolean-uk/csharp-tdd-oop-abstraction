using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Accounts
{
    public abstract class Account
    {
        private string? _email;
        private string? _password;
        private bool _isEnabled;

        public Account(string email, string password)
        {
            if (!IsValidEmail(email)) { throw new ArgumentException("Email does not conform to our standards."); }

            if (!IsValidPassword(password)) { throw new ArgumentException("Passord does not conform to our standards"); }

            _email = email;
            _password = password;
            _isEnabled = false;
        }

        public bool IsValidEmail(string email)
        {
            if (!(email.Contains('@') || email == null))
            {
                Console.WriteLine("invalid email");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsValidPassword(string password)
        {
            if (password.Length < 8 || password == null)
            {
                Console.WriteLine("invalid password");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void EnableAccount(Account acc)
        {
            if (acc is SystemAdministrator)
            {
                _isEnabled = true;
            }
        }

        public virtual bool IsEnabled() { return _isEnabled; }

        public virtual bool CanLogIn() { return _isEnabled; }
    }
}
