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
            
        }

        public string toggleUser(User user)
        {
            throw new NotImplementedException();
        }

        protected internal override void Enable()
        {
            throw new NotImplementedException();
        }
    }
}
