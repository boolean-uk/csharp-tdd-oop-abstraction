using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{

    // Enum for account status
    public enum AccountStatus
    {
        Disabled,
        Enabled
    }

    public class User
    {
        // Attributes
        private string _email;
        private string _password;
        private AccountStatus _accountStatus; // Use the AccountStatus enum

        // Constructor for User Account Creation
        public User(string email, string password)
        {
            // Validate email and password during account creation
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email");
            }

            if (!IsValidPassword(password))
            {
                throw new ArgumentException("Invalid password");
            }

            // Set attributes
            _email = email;
            _password = password;
            _accountStatus = AccountStatus.Disabled; // New accounts are disabled by default
        }


        // Method for Password Validation
        public bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        // Method for Email Validation
        public bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        // Method for Enabling the User Account
        public void Enable()
        {
            _accountStatus = AccountStatus.Enabled;
        }

        // Method for Disabling the User Account
        public void Disable()
        {
            _accountStatus = AccountStatus.Disabled;
        }

        // Method for Checking if the Account is Enabled
        public bool IsEnabled()
        {
            return _accountStatus == AccountStatus.Enabled;
        }

        // Properties for accessing email and account status
        public string Email
        {
            get { return _email; }
        }

        public AccountStatus Status
        {
            get { return _accountStatus; }
        }

        // Property for accessing password (optional)
        public string Password
        {
            get { return _password; }
        }
    }
}
