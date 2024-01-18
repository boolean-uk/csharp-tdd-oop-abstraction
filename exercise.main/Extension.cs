using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Extension
    {


        
    }

    public class Account
    {
        private string _userPassword;
        private string _userEmailAddress;

        public enum roll { User, Admin }
        
        private roll _roll;
        public bool AccountEnabeled;
        public Account(string userPassword, string userEmail) 
        {
            _userPassword = userPassword;
            _userEmailAddress = userEmail;
            _roll = roll.User;
            AccountEnabeled = false;
        }
        public Account(string userPassword, string userEmail, string AdminVerification)
        {
            _userPassword = userPassword;
            _userEmailAddress = userEmail;
            if (AdminVerification == "ADMIN")
	        {
                _roll = roll.Admin;
                AccountEnabeled = true;

            }

        }

        public string UserPassword { get { return _userPassword; } }
        public string UserEmailAddress { get { return _userEmailAddress; } }
        public roll AcountRoll { get { return _roll; } }
        
    }


    public class WebPage
    {
        Dictionary<string, Account> accounts;

        public WebPage() 
        {
            accounts = new Dictionary<string, Account>();
        }

        public Dictionary<string,Account> Accounts { get { return accounts; } }

        public string createAcount(string userPassword, string email)
        {
            if (accounts.ContainsKey(email))
            {
                return new string("There is already an account with that email");
            }

            if(userPassword.Count() >= 8 && email.Contains('@'))
            {
                Account account = new Account(userPassword, email);
                accounts.Add(email, account);
                return new string("New account was made");
            }
            else if (userPassword.Count() < 8)
            {
                return new string($":{userPassword}: is not a valid password (it needs at least 8 characters)");
            }
            else
            {
                return new string($":{email}: is not a valid email (a valid email needs to contain an @ )");
            }
            

            
        }
        public string createAcount(string userPassword, string email, string AdminVerification)
        {
            if (accounts.ContainsKey(email))
            {
                return new string("There is already an account with that email");
            }

            if (userPassword.Count() >= 8 && email.Contains('@') && AdminVerification == "ADMIN")
            {
                Account account = new Account(userPassword, email, AdminVerification);
                accounts.Add(email, account);
                return new string("New account was made");
            }
            else if (userPassword.Count() < 8)
            {
                return new string($":{userPassword}: is not a valid password (it needs at least 8 characters)");
            }
            else
            {
                return new string($":{email}: is not a valid email (a valid email needs to contain an @ )");
            }
        }

        public string LogIn(string userPassWord, string email)
        {
            if (accounts.ContainsKey(email) && accounts[email].UserPassword == userPassWord)
            {
                if (accounts[email].AccountEnabeled == true) 
                {
                    return new string("You are now loged in :)");
                }
                else
                {
                    return new string("Your account needs to be verified by an Admin to be able to log in");
                }
                
            }
            else
            {
                return new string("Wrong password or Email");
            }
        }


        public string enableAccount(string EmailtoEnable, string AdminEmailForVerification)
        {
            if (accounts.ContainsKey(EmailtoEnable))
            {
                if (accounts.ContainsKey(AdminEmailForVerification))
                {
                    if(GetAccount(AdminEmailForVerification).AcountRoll == Account.roll.Admin)
                    {
                        GetAccount(EmailtoEnable).AccountEnabeled = true;
                        return new string("Account was enabeled");
                    }
                    else
                    {
                        return new string("Not a valid Admin verification");
                    }
                }
                else
                {
                    return new string("Not a valid Admin verification");
                }
            }
            else
            {
                return new string("Not a valid email. No account is using it.");
            }
        }

        public Account GetAccount(string email)
        {
            bool AccountExists = false;

            if (accounts.ContainsKey(email))
            {
                AccountExists = true;
            }
            if (AccountExists)
            {
                return accounts[email];
            }
            return null;
        }
    }

}
