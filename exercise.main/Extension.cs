using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserAccount
    {
        private string email;
        private string password;
        private string status;


        public UserAccount(string email, string password)
        {
            this.status = "disabled";
            // Validate email
            if (IsValidEmail(email))
            {
                this.email = email;
            }
            else
            {
                throw new ArgumentException("Invalid email");
            }

            // Validate password
            if (IsValidPassword(password))
            {
                this.password = password;
            }
            else
            {
                throw new ArgumentException("Invalid password");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Basic email validation
            return email.Contains("@");
        }

        private bool IsValidPassword(string password)
        {
            // Basic password validation
            return password.Length >= 8;
        }

       
        public string GetEmail()
        {
            return email;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public bool IsEnabled() 
        {
            if (this.status == "disabled")
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public bool enableAccount()
        {
            this.status = "enabled";
            if(this.status == "enabled")
            {
                return true;
            }
            else { return false; }
        }

        public bool disableAccount()
        {
            this.status = "disabled";
            if (this.status == "disabled")
            {
                return true;
            }
            else { return false; }
        }
    }
}
