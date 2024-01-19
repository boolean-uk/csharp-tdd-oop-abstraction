using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Admin : Account
    {
        public Admin() : base() 
        {
            _admin = true;
        }

        public bool approveAccount(string username, string email)
        {
            if(username.Length >=8 && email.Contains("@"))
            {
                _users.Add(new User(username, email));
                Console.WriteLine("account created!");
                return true;
            }

            else if (username.Length < 8)
            {
                Console.WriteLine("invalid password!");
                return false;
            }
            else if (!email.Contains("@"))
            {
                Console.WriteLine("invalid email!");
                return false;
            }
            return false;
        }

    }
}
