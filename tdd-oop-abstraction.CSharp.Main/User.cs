using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class User
    {
        private string role;
        public User(string role)
        {
            this.role = role;
        }

        public string Role { get => role; }
    }
}
