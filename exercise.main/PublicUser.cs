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
                
        }

        protected string SetPassword()
        {
            throw new NotImplementedException();
        }

        protected string SetEmail()
        {
            throw new NotImplementedException();
        }

        protected internal override void enable()
        {
            throw new NotImplementedException();
        }
    }
}
