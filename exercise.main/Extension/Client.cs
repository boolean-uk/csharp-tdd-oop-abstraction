using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class Client
    {

        private string _email; private string _password;
        private bool disabled = true;
        public bool Create(string email, string password, out string message)
        {
            if( !email.Contains('@'))
            {
                message = "email needs to be a valid email";
                return false;
            }
            if ( password.Count() < 8)
            {
                message = "Password needs to be more than 7 letters long";
                return false;
            }
            _email = email;
            _password = password;
            message = "User has been sucessfully created";
            return true;
        }

        public void enable()
        {
            disabled = false;
        }

        public bool Login(string email, string password, out string message)
        {
            if ( disabled )
            {
                message = "Your used is disabled";
                return false;
            }
            
            if (email != _email) 
            {
                message = "You have inputed the wrong email for this account"; 
                return false; 
            }
            if (password != _password)
            {
                message = "You have inputed the wrong password for this account";
                return false;
            }
            message = "You are loged in!";
            return true;
        }
    }
}
