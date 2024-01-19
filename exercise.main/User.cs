using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;
        public User(string name, string email, string password)
        {
            _name = name;
            _email = email;
            _password = password;
        }

        public bool validEmail()
        {
            return (_email.Contains("@"));
        }

        public bool validPassword()
        {
            return (_password.Length > 8);
        }
    }
}
