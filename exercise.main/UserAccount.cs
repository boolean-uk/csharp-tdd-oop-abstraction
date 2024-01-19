using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserAccount
    {
        private string _name;
        private string _password;
        private string _email;
        

        public UserAccount(string name, string password, string email)
        {
            _name = name;
            _password = password;
            _email = email;
        }

        public bool ValidPassword { get { return _password.Length > 7; } }
        public bool ValidEmail { get { return _email.Contains("@"); } }

        public string Name { get { return _name; } }

        public bool ConfirmPassword(string password) 
        { 
            return _password.Equals(password); 
        }
    }
}
