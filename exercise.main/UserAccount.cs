using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserAccount : BaseAccount
    {
        protected bool _enabled;
        public UserAccount(string email, string password) : base(email, password)
        {
            
        }
        
        public bool canLogIn()
        {
            return _enabled;
        }

        protected internal bool enable()
        {
            throw new NotImplementedException();
            _enabled = true;
            return _enabled;
        }
    }
}
