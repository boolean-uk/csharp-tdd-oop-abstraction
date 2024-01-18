using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Objects
{
    public class AccountObj
    {
        private Guid _id;
        private string _password;
        private string _email;
        private bool _isEnabled;

        public AccountObj(string Password, string Email)
        {
            _id = Guid.NewGuid();
            _password = Password;
            _email = Email;
            _isEnabled = false;
        }
        public bool getEnabled() {  return _isEnabled; }
        protected internal void EnableAccount(bool Enable)
        {
            _isEnabled = Enable;
            
        }
    }
}
