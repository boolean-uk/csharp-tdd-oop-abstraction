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
        public Account()
        { 
            _enabled = false;
        }

        public string CreateAccount(string email, string password)
        {
            if (!checkEmail(email))
            {
                return "email needs @"; 
            }
            if(!checkPassword(password))
            {
                return "password can not be less than 8";
            }
            this._email = email;
            this._password = password;
            return "account created";
        }

        private bool checkEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false; 
        }

        private bool checkPassword(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        public bool CanLogIn()
        {
            return _enabled;
        }

        public void SetEnabled()
        {
            _enabled = true;
        }
    }
}
