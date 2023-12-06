using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class Account
    {
        private string _emailaddress;
        private string _password;
        private bool _status;
        //private string _message = string.Empty;

        public Account(string emailaddress, string password)
        {
            this._emailaddress = emailaddress;
            this._password = password; //SetPassword()
            this._status = false;
        }

        public void setStatus(bool status)
        {
            this._status = status;
        }
        public bool getStatus()
        {
            return this._status;
        }

        public string VisibleEmail { get { return _emailaddress; } set { _emailaddress = value; } }
        public bool VisibleStatus { get { return _status; } set { _status = value; } }


    }
}
