using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    //Class: UserAccount
    public class UserAccount
    {
        //Properties
        public string Email {  get; private set; }
        public string Password { get; private set; }
        public bool IsEnabled { get; private set; }

        //Constructor
        public UserAccount(string email, string password) 
        {
            SetEmail(email);
            SetPassword(password);
            IsEnabled = false;
        }

        //Enable Account
        public void EnableAccount()
        {
            IsEnabled = true;
        }

        //DisableAccount
        public void DisableAccount() 
        {  
            IsEnabled = false; 
        }

        //SetEmail
        private void SetEmail(string email) 
        { 
            if (email.Contains("@"))
            {
                Email = email;
            }
            else 
            {
                throw new ArgumentException("Invalid email address");
            }
        }

        //SetPassword
        private void SetPassword(string password) 
        {
            if (password.Length >= 8) 
            {
                Password = password;
            }
            else { throw new ArgumentException("Invalid Password Length"); }
        }
    }
}
