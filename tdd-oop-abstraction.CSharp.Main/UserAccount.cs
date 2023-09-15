using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class UserAccount
    {
        private string email;
        private string password;
        private bool isAccountEnabled;
        private string validationMessage;
        public UserAccount(string email)
        {
            this.email = email;
            isAccountEnabled = false;
            validationMessage = string.Empty;
        }
        public string ValidationMessage
        {
            get { return validationMessage; }
        }
        public void SetPassword(string password)
        {
            this.password = password;
            Validate();
        }
        public bool IsThePasswordValid()
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }
        public void EnableAccount()
        {
            isAccountEnabled = true;
        }
        public void DisableAccount()
        {
            isAccountEnabled = false;
        }
        public bool IsTheAccountEnableOrDisable()
        {
            return isAccountEnabled;
        }
        public bool IsEmailValid()
        {
            return email.Contains("@");
        }
        private void Validate()
        {
            if (!IsEmailValid() || !IsThePasswordValid())
            {
                validationMessage = "The email or password is invalid";
            }
            else
            {
                validationMessage = "The account is created succesfully";
            }
        }
    }
}