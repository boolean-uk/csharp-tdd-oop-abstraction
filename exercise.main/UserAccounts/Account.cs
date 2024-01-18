using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercise.main.UserAccounts
{
    public abstract class Account
    {
        private string _username;
        private string _password;
        protected bool _enabled;

        public KeyValuePair<string,bool> validatePassWord(string word) { 
            bool isValid = false;
            string message = "";

            if((word != null) && (word.Length >= 8))
            {
                isValid = true;
                message = "";
            }
            else
            {
                isValid = false;
                message = "invalid password";
            }
            return new KeyValuePair<string, bool>(message,isValid); }
        public bool validateUsername(string userName) { return _username != null; }

        public virtual bool enableAccount() {
            return false;
        }
        public string Username { get; set; }
       

        
    }
}
