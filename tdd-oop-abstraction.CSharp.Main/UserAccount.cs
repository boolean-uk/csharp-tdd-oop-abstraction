using NUnit.Framework.Internal;
using NUnit.Framework;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class UserAccount
    {
        public string Email { get; }

        public bool IsEnabled { get; private set; }

        private string Password { get; set; }

        public UserAccount(string email, string password)
        {
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email address.");
            }

            SetPassword(password);
            IsEnabled = false; 
            Email = email;
        }

        public void EnableAccount()
        {
            IsEnabled = true;
        }

        public void DisableAccount()
        {
            IsEnabled = false;
        }

        public bool ValidatePassword(string password)
        {
            return Password == password;
        }

        private void SetPassword(string password)
        {
            if (password.Length < 8)
            {
                throw new ArgumentException("Invalid password: Password must be at least 8 characters long.");
            }

            Password = password;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        public bool SignIn(string email, string password)
        {
            if (!IsValidEmail(email) || !IsEnabled)
            {
                return false;
            }

            return ValidatePassword(password);
        }
    }
}
