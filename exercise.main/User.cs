using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _password;
        private string _email;
        private bool _status = false;

        public User(string password, string email)
        {
            this._password = password;
            this._email = _email;
        }

        public User ()
        {

        }

        public string passWordCreate(string password)
        {
            if (password.Length >= 8) 
            {
                _password = password;
                return "success!";
            }
            else
            {
                return "invalid!";
            }
        }

        public string EmailCreate(string email)
        {
            if (email.Contains("@"))
            {
                _email = email;
                return "success!";
            }
            else
            {
                return "invalid!";
            }
        }

        public bool getStatus()
        {
            return _status;
        }

        public void setAccountEnabled()
        {
            this._status = true;
        }

        public void setAccountInabled()
        {
            this._status = false;
        }

    }
}
