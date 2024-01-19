using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _status = false;
        private bool _signedIn = false;
        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }
        public bool Status { get { return _status; } set { _status = value; } }
        public bool SignedIn { get { return _signedIn; } set { _signedIn = value; } }
        public string Email { get { return _email; } }
        public string Password { get { return _password; } }
    }
}
