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
            return "";
        }

        public string SetPassword(string password)
        {
            return "";
        }

        public void DisableAccount(UserAccount account)
        {

        }

        public void EnableAccound(UserAccount account)
        {

        }

        public bool CanLogin(UserAccount account)
        {
            return false;
        }
    }
}