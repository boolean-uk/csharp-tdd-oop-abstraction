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
        private bool _enabled = false;

        public User(string email, string password)
        {
            if(!email.Contains("@"))
            {
                throw new ArgumentException("Invalid email");
            }
            if(password.Length < 8)
            {
                throw new ArgumentNullException("You must provide a password of at least 8 characters");
            }
            _email = email;
            _password = password;
        }

        private void SetEnable()
        {
            _enabled = !_enabled;
        }
    }
}
