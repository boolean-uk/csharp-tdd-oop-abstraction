using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User :  Account
    {
        public User(string email, string password) : base(email, password)
        {
        }
    }
}
