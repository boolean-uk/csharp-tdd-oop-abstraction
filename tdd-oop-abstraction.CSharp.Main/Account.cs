using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class Account
    {
        private string _email;
        private string _password;
        private bool _isEnabled;

        public Account(string email, string password)
        {
            _email = email;
            _password = password;
            _isEnabled = false;
        }

        public void SetEnabled()
        {
            _isEnabled = true;
        }

        public bool IsEnabled { get => _isEnabled; }
    }
}