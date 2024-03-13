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
    public enum UserRole { User, Admin }
    public class Account
    {
        private string _userPassword;
        private string _userEmailAddress;
        private UserRole _role;
        private bool _accountEnabeled;
        public Account(string userPassword, string userEmail) 
        {
            _userPassword = userPassword;
            _userEmailAddress = userEmail;
            _role = UserRole.User;
            _accountEnabeled = false;
        }
        public Account(string userPassword, string userEmail, UserRole userRole) // this constructor is needed to be able to create an account with Admin role.  
        {
            _userPassword = userPassword;
            _userEmailAddress = userEmail;
            if (userRole == UserRole.Admin)
            {
                _role = UserRole.Admin;
                _accountEnabeled = true;

            }
            else
            {
                _role = userRole;
                _accountEnabeled = false;
            }

        }

        public string UserPassword { get { return _userPassword; } }
        public string UserEmailAddress { get { return _userEmailAddress; } }
        public UserRole AccountRole { get { return _role; } }

        public bool AccountEnabeled { get { return _accountEnabeled;} }

        public void EnableAccount(Account account)
        {
            if (account.AccountRole == UserRole.Admin) 
            {
                _accountEnabeled = true;
            }
            
        }


    }


    public class WebPage
    {
        Dictionary<string, Account> accounts;

        Account LoggedInAcount = new Account("", "");  

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

        //store the loged in user as variabel to test if it is an Admin
        public string createAcount(string userPassword, string email, UserRole userRole)
        {
            if (accounts.ContainsKey(email))
            {
                return new string("There is already an account with that email");
            }
            if (userRole != UserRole.Admin)
            {
                return new string("Not valid UserRole for this function.");
            }

            if (userPassword.Count() >= 8 && email.Contains('@') )
            {
                Account account = new Account(userPassword, email, userRole);
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
                    
                    LoggedInAcount = accounts[email];
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


        public string enableAccount(string EmailtoEnable)
        {
            if (accounts.ContainsKey(EmailtoEnable))
            {
                if (LoggedInAcount.AccountRole == UserRole.Admin)
                {

                    GetAccount(EmailtoEnable).EnableAccount(LoggedInAcount);
                    return new string("Account was enabeled");
                    
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
