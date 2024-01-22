using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.AccountManager
{
    public class Account
    {
        private Guid _id;
        private string _email;
        private string _password;
        private bool _isEnabled;


        public Account(string password, string email) 
        {
            _id = Guid.NewGuid();
            _password = password;
            _email = email;
            _isEnabled = false;
        }

        public bool getEnabled() 
        {
            return _isEnabled; 
        }

        protected internal void EnableAccount(bool enable)
        {
            _isEnabled = enable;
        }
    }

    
}
