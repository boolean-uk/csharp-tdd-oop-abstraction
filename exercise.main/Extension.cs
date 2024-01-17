using System;
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
        public void createUser()
        {

        }
        public bool canLogin()
        {
            return _enabled;
        }
        
    }
    public class Admin
    {
        public Admin() 
        {
            
        }
        public bool checkUser(string password, string email)
        {
            return false;
        }
        public bool enableUser(User user)
        {
            user._enabled = true;
            return true;
        }
    }
}
