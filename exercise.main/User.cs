using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        // private for better abstraction, can only be accessed within this class
        private string _email;
        private string _password;
        private bool _enabled = false;

        public User (string email, string password)
        {
            this._email = email;
            this._password = password;
        }

        public List<User> users = new List<User> ();

        public void setEnabled(bool enabled)
        {
            this._enabled = enabled;
        }

        public void create(string email, string password)
        {
            this._email = email;
            this._password = password;
        }

        public bool validPassword(User user)
        {
            if (user._password.Length < 8)
            {
                return false;
            }
            else return true;
        }

        public bool validEmail(User user)
        {
            if (user._email.Contains('@'))
            {
                return true;
            }
            else return false;
        }

        public bool disabledByDefault(User user)
        {
            return user._enabled;
        }

        public bool canLogin(User user)
        {
            if (user._enabled == true)
            {
                return true;
            }
            else return false;
        }
    }
}
