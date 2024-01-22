using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class AdminAccount : Account
    {
        public AdminAccount(string email, string password) : base(email, password) { }
    }
}
