using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserAccount
    {
        private string email;
        private string password;
        private bool enabled = true;

        public UserAccount()
        {

        }

        public string SetEmail(string email)
        {
            string message = "";

            if (!email.Contains("@"))
                message = "Invalid email";
            else
                message = "Valid email";

            return message;
        }

        public string SetPassword(string password)
        {
            string message = "";

            if (password.Length < 8)
                message = "Invalid password";
            else
                message = "Valid password";

            return message;
        }

        public void DisableAccount()
        {
            this.enabled = false;
        }

        public void EnableAccount()
        {
            this.enabled = true;
        }

        public bool CanLogin()
        {
            return this.enabled;
        }
    }
}