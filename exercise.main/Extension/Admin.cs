
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
   public class Admin : Account
    {
        public void enableAccount(string userName, bool newStatus)
        {
            if (_Users.ContainsKey(userName)) {
                _Users[userName] = newStatus;
                bool test = _Users[userName];
            }
            
        }
    }
}
