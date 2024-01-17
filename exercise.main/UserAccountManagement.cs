using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User {
        public string userName;
        public string email;
        public string password;
        public bool state;
    }
    public class UserAccountManagement
    {
        private List<User> users;

        public UserAccountManagement() {
            users = new List<User>();
        }

        public void CreateAccount(string userName, string email, string password) {
            
            try {
                if (isValidEmail(email)) {
                    if (isValidPassword(password)) {
                        User newUser = new User {
                            userName = userName,
                            email = email,
                            password = password,
                            state = false
                        };
                        users.Add(newUser);
                    } 
                }
            } catch (Exception e) {
                Console.WriteLine(e); // For the requierments
                throw; // Hade to re throw for the tests
            }
            
        }

        public bool isAccountActive(string userName) {
            foreach (User tmp in users)
            {
                if (tmp.userName.Equals(userName))
                {
                    return tmp.state;
                }
            }
            return false;
        }

        public void ChangeAccountState(string userName, bool state) {
            foreach (User tmp in users)
            {
                if (tmp.userName.Equals(userName))
                {
                    tmp.state = state;
                }
            }
        }

        private bool isValidPassword(string password)
        {
            if (password.Length >= 8) {
                return true;
            } else {
                throw new Exception("invalid password");
            }
        }

        private bool isValidEmail(string email)
        {
            if (!string.IsNullOrEmpty(email) && email.Contains("@")) {
                return true;
            } else {
                throw new Exception("invalid email");
            }
        }
    }
}