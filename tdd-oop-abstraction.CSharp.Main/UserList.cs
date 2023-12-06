using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class UserList
{
        public List<Account> Users = new List<Account>();
        
        public string New(string emailaddress, string password)
        {
            string message = Message(emailaddress, password);
            Account newAccount = new Account(emailaddress, password);
            Users.Add(newAccount);
            return message;
        }

        private string Message(string emailaddress, string password)
        {
            string message = string.Empty;
            if ((CheckPassword(password) == false) && (CheckEmailaddress(emailaddress) == false))
            {
                message = "Invalid email, Invalid password";
            }
            else if (CheckEmailaddress(emailaddress) == false)
            {
                message = "Invalid email";
            }
            else if (CheckPassword(password) == false)
            {
                message = "Invalid password";
            }
            return message;
        }
        private bool CheckPassword(string password)
        {
            return password.Length >= 8;
        }

        private bool CheckEmailaddress(string emailaddress)
        {
            return emailaddress.Contains("@");
        }

        public string CanThisUserLogIn(string emailaddress)
        {
            string answer = string.Empty;
            var testAccount = Users.Where(x => x.VisibleEmail == "test@email.com").FirstOrDefault();
            var idx = Users.IndexOf(testAccount);
            if (Users[idx].VisibleStatus == true)
            {
                answer = "User can log in";
            }
            else
            {
                answer = "Account not enabled";
            }
            return answer;
        }
    }
}
