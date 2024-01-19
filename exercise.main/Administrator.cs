using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Administrator
    {
        private List<UserAccount> _accounts = new List<UserAccount>();
        private List<UserAccount> _enabledAccounts = new List<UserAccount>();

        public void AddUser(UserAccount user)
        {
            if (_accounts.Contains(user) == true) { Console.WriteLine("Username not available"); }
            else if (verifyUser(user)) { _accounts.Add(user); }
        }

        private bool verifyUser(UserAccount user)
        {
            bool verified = false;
            if (user.ValidPassword == false) { Console.WriteLine("Not a valid password"); }
            else if (user.ValidEmail == false) { Console.WriteLine("Not a valid email-address"); }
            else { verified = true; }
            return verified;
        }

        public void EnableUser(UserAccount user)
        {
            if (_accounts.Contains(user) == false) { Console.WriteLine("No such user to enable"); }
            else if (verifyUser(user)) { _enabledAccounts.Add(user); }
        }

        public int GetEnabledUserCount()
        {
            return _enabledAccounts.Count;
        }

        public int GetUserCount()
        {
            return _accounts.Count;
        }

        public void DisableUser(UserAccount user)
        {
            if (_enabledAccounts.Contains(user) == false) { Console.WriteLine("No such user to disable"); }
            else {  _enabledAccounts.Remove(user); }
        }

        public bool LogIn(string username, string password)
        {
            UserAccount? user = _enabledAccounts.Where(user => user.Name == username).FirstOrDefault();

            if (user == null) {
                Console.WriteLine("The username or password is not correct");
                return false;
            }
            else if (!user.ConfirmPassword(password))
            {
                Console.WriteLine("The username or password is not correct");
                return false;
            }
            else 
            {
                Console.WriteLine("You successfully logged in!");
                return true; 
            }

        }
    }
}
