using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Admin
    {
        private string _email;
        private string _password;
        private bool _isEnabeled;
        private List<User> _users;

        public Admin(string Email, string Password)
        {
            this._email = Email;
            this._password = Password;
            this._isEnabeled = true;
            this._users = new List<User>();
        }

        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public bool IsEnabeled { get { return _isEnabeled; } }
        public List<User> Users { get { return _users; } set { _users = value; } }

        public void setEnabeled()
        {
            _isEnabeled = true;
        }
        public void createUserAccount(string email, string password)
        {
            User user = new User(email, password);
            if(checkPassword(password) && checkEmail(email)) 
            {
                _password = password;
                _email = email;
                _users.Add(user);
            }
            _isEnabeled = false;
        }

        public void createAdminAccount(string email, string password)
        {
            if (checkPassword(password) && checkEmail(email))
            {
                _password = password;
                _email = email;
            }
            _isEnabeled = true;
        }

        public bool checkPassword(string password)
        {
            string msg = "";
            if (password.Length > 8) 
            {
                Console.WriteLine("Password must be 8 characters or more");
                return false;
            }

            return true;
        }

        public bool checkEmail(string email) 
        {
            
            int indexOfAt = FindIndexOfCharacter(email, '@');

            if (indexOfAt == -1)
            {
                Console.WriteLine("The character '@' is not present in the email address.");
                return false;
            }

            return true;

        }

        private int FindIndexOfCharacter(string input, char character)
        {
            return input.IndexOf(character);
        }

        public bool login()
        {
            if(_isEnabeled == false)
            {
                Console.WriteLine("Your account is not ready yet");
                return false;
            }
            else
            {
                Console.WriteLine("logged in");
                return true;
            }
        }

    }
}
