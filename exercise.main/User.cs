using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class User
    {
        public string _email { get; protected set; }
        public string _password { get; protected set; }
        public bool _enabled { get; protected set; }

        protected internal abstract void Enable();

        public string SetPassword(string password)
        {
            throw new NotImplementedException();
        }

        public string SetEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool CheckStatus()
        {
            throw new NotImplementedException();
        }
    }
}
