﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _password;
        private string _email;
        public bool _enabled;
        public User(string password, string email)
        {
            _password = password;
            _email = email;
            _enabled = false;
            
        }
        public bool canLogin()
        {
            if (_enabled == true)
            {
                Console.WriteLine("Your account has been enabled!");
            }
            else if (_enabled == false)
            {
                Console.WriteLine("Your accound has not been enabled, please wait for admin!");
            }
            return _enabled;
        }
    }
    public class Admin
    {
        public bool enableUser(User user)
        {
            user._enabled = true;
            return true;
        }
    }
    public class Extension
    {
        private List<User> users = new List<User>();
        public bool addUser(string password, string email)
        {
            bool checkPass = checkPassword(password);
            bool checkEm = checkEmail(email);
            if (checkPass == true)
            {
                if (checkEm == true)
                {
                    users.Add(new User(password, email));
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid email!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid password!");
                return false;
            }           
        }
        private bool checkPassword(string password)
        {
            if(password.Count() >= 8)
            {
                return true;
            }
            return false;
        }
        private bool checkEmail(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }
    }
}
