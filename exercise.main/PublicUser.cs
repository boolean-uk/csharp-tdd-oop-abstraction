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

        protected internal override void Enable()
        {
            throw new NotImplementedException();
        }
    }
}
