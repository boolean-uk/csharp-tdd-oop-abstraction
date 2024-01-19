using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class SystemAdministrator : Account
    {
        private bool _isEnabled; // Admin account are default enabled

        public SystemAdministrator(string email, string password) : base(email, password)
        {
            _isEnabled = true;
        }

        public override bool IsEnabled()
        {
            throw new NotImplementedException();
        }
    }
}
