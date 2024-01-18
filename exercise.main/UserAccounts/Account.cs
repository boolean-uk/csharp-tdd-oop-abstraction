using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise.main.UserAccounts
{
    public abstract class Account
    {
        private string _username = string.Empty;
        private string _password = string.Empty;
        private bool _enabled = false;
        private bool _isAdmin = false;

        public bool EnableAccount(User user) {
            if (_isAdmin)
            {
                user._enabled = true;
                return true;
            }
            return false;
        }

        protected void setAdmin(bool admin) {
        _isAdmin = admin;
            _enabled = admin;
        }

        public string createAccount(string name, string password)
        {
            string message = "Account created";
            if(ValidateUsername(name))
            {
                _username = name;
            }
            else { message = "Invalid email"; }
            if(ValidatePassword(password))
            {
                _password = password;
            }
            else { if (message == string.Empty) { message = "Invalid password"; } else { message += ", Invalid password"; } }
            return message;
        }

        private bool ValidateUsername(string name)
        {
            return name.Contains("@")? true:false;
        }

        private bool ValidatePassword(string password)
        {
            return password.Length>=8 ? true : false;
        }

        public bool logIn()
        {
            return _enabled;
        }
  
        public bool isAdmin { get => _isAdmin; }
        public bool IsEnabled { get => _enabled; }

    }
}
