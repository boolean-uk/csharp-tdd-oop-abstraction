using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private string _status;

        public User (string email, string password)
        {
            _email = email;
            _password = password;
            _status = "Disabled";
        }

        public string Email { get { return _email; } set { _email = value; } } 
        public string Password { get { return _password;} set { _password = value; } }
        public string Status { get { return _status; } set { _status = value; } }
    }
}
