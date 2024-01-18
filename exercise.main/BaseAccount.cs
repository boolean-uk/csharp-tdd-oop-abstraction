using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class BaseAccount
    {
        protected readonly string _email; 
        private readonly string _password;

        public BaseAccount(string email, string password)
        {
            _email = email;
            _password = password;
        }
    }
}
