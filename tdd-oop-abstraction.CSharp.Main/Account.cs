using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class Account
    {
        private bool isActivated;
        private string email;
        private string password;

        public Account()
        {
            this.isActivated = false;
        }

        public string CreateAccount(User user,string email, string password)
        {
            if (user.Role.Equals("User"))
            {
                bool emailResult = CreateEmail(email);
                bool passwordResult = CreatePassword(password);
                if (emailResult == true && passwordResult == true)
                {
                    return "Account has been created successfully";
                }
            }
            return "Account has not been created";
        }

        private bool CreateEmail(string email)
        {
            if (email.Contains("@"))
            {
                this.email = email;
                return true;
            }
            return false;
        }

        private bool CreatePassword(string password)
        {
            if (password.Length > 8)
            {
                this.password = password;
                return true;
            }
            return false;
        }

        private bool ableToLogIn()
        {
            if (this.isActivated)
            {
                return true;
            }
            return false;
        }

        public bool AbleToLogIn(User user)
        {
            if (user.Role.Contains("User"))
            {
                return ableToLogIn();
            }
            return false;
        }

        private void enableAccount ()
        {
            this.IsActivated = true;
        }

        public bool EnableAccount(User user)
        {
            if (user.Role.Contains("Admin"))
            {
                enableAccount();
                return true;
            }
            return false;
        }

        public bool IsActivated { get => this.isActivated; set => this.isActivated = value; }
    }
}
