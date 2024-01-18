using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class User
    {
        protected string _email { get;  set; }
        protected string _password { get; set; }
        protected bool _enabled { get; set; }

        protected internal abstract bool Enable();


        public string SetPassword(string password)
        {
            if(password.Length >= 8)
            {
                _password = password;
                return String.Empty;
            }
            return "invalid password";
        }

        public string SetEmail(string email)
        {
            if(email.Contains("@"))
            {
                _email = email;
                return String.Empty;
            }
            return "invalid email";
        }

        public bool CheckStatus()
        {
            return _enabled;
        }

        public bool CheckPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
