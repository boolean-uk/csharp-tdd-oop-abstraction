using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string email;
        private string password;
        private bool isEnabled;

        public User(string email, string password)
        {
            this.setEmail(email);
            this.setPassword(password);
            this.isEnabled = false;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string setEmail(string email)
        {
            if (email.Contains("@"))
            {
                this.email = email;
                return "Email succesfully set";
            }
            return "Invalid email";

        }

        public string getPassword()
        {
            return this.password;
        }

        public string setPassword(string password)
        {
            if(password.Length >= 8)
            {
                this.password = password;
                return "Password succesfully set";
            }
            return "Password should be at least 8 characters long";
        }

        public bool getIsEnabled()
        {
            return this.isEnabled;
        }

        public void setIsEnabled(bool isEnabled)
        {
            this.isEnabled = isEnabled;
        }

        public string isAbleToLogin()
        {
            if (getIsEnabled())
            {
                return "You're able to login";
            }
            return "You're not able to login";
        }
    }
}
