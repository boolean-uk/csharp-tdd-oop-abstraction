using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private Account _account;
        public bool CreateAccount(string email, string password)
        {
            try
            {
                Account account = new(email, password);
                _account = account;
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool LogIn(string email, string password)
        {
            return _account.LogIn(email, password);
        }
    }
}
