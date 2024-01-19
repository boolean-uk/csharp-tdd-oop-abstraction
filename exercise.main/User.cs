using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise.main
{
    public class User : Account
    {
        private string _password;
        private string _email;

        public string Password { get { return _password; } }
        public string Email { get { return _email; } }
        internal User(string password, string email)
        {
            _password = password;
            _email = email;
        }


    }
}
