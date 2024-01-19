using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class Account
    {
        public bool _admin = false;
        public bool _status = false;
        public List<User> _users = new List<User>();

        public Account()
        {
            this._admin = false;
            this._status = false;
        }

        public User getAccount(string password, string email)
        {
            return _users.FirstOrDefault(x => x.Password == password && x.Email == email);
        }

        public void setAccountEnabled(User user)
        {
            if (_admin == true)
            {
                user._status = true;
            }
           
        }

        public void setAccountInabled(User user)
        {
            if (_admin == true)
            {
                user._status = false;
            }
        }

        public bool canLogin()
        {
            if (_status)
            {
                Console.WriteLine("Your account is active - you can login!");
                return true;
            }

            Console.WriteLine("Your account is not active - you can not login yet!");
            return false;
        }

        public bool getStatus()
        {
            return _status;
        }

    }
}
