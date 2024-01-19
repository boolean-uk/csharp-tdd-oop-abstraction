using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class UserInformation
    {
        public string _email { get; set; }
        public string _password { get; set; }
        public bool _enabled { get; set; }

        public UserInformation(string email, string password)
        {
            this._email = email;
            this._password = password;
            this._enabled = false;
        }
    }
}
