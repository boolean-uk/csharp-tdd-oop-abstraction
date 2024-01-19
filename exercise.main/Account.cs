using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class Account
    {
        private string _email;
        private string _password;
        private bool _isLoggedIn = false;
        private bool _isEnabled = false;
        private bool _isAdmin = false;

        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public bool IsLoggedIn { get => _isLoggedIn; set => _isLoggedIn = value; }
        public bool IsEnabled { get => _isEnabled; }
        public bool IsAdmin { get => _isAdmin; }

        public Account(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void EnableAccount(User acc, bool isEnabled)
        {
            if(_isAdmin)
            {
                acc._isEnabled = isEnabled;
            }
        }

        protected void setAdmin(bool becomesAdmin)
        {
            _isAdmin = becomesAdmin;
            _isEnabled = becomesAdmin;
        }

    }
}
