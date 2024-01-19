﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public abstract class Account
    {
        private string? _email;
        private string? _password;
        private bool _isEnabled;

        public Account(string email, string password)
        {
            if (validateEmail(email)) { _email = email; }

            if (validatePassword(password)) { _password = password; }
            _isEnabled = false;
        }

        public bool validateEmail(string email)
        {
            if (!email.Contains('@'))
            {
                Console.WriteLine("invalid email");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validatePassword(string password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("invalid password");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void EnableAccount(Account acc)
        {
            if (acc is SystemAdministrator)
            {
                _isEnabled = true;
            }
        }

        public virtual bool IsEnabled() { return _isEnabled; }

        public bool CanLogIn() { return _isEnabled; }
    }
}
