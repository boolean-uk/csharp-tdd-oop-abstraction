using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class AdminUser : User
    {
        public AdminUser(string email = "admin", string password = "admin") 
        {
            _enabled = true;
        }

        public string toggleUser(User user)
        {
            user.Enable();
            return $"user enabled: {user.CheckStatus}";
        }

        protected internal override bool Enable()
        {
            return true;
        }
    }
}
