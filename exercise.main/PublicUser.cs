using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class PublicUser : User
    {
        public PublicUser() 
        { 
            _email = string.Empty;
            _password = string.Empty;
        }

        protected internal override bool Enable()
        {
            if (_enabled)
            {
                _enabled = false;
            }
            else 
            { 
                _enabled = true; 
            }
            return _enabled;
        }
    }
}
