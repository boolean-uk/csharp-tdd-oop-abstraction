using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserAccount : BaseAccount
    {
        protected bool _isEnabled; 

        public UserAccount(string email, string password) : base(email, password) 
        {
            _isEnabled = false;
        }

        public string GetEmail() { return _email; }

        public bool CanUserLogin()
        {
            return _isEnabled;
        }

        protected internal bool EnableLogin()
        {
            _isEnabled = true;
            return _isEnabled;
        }


    }
}
