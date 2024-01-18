using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class User
    {
        protected internal string _email;
        protected internal string _password;
        public bool _enabled { get; protected set; }

        protected internal abstract void enable();
    }
}
