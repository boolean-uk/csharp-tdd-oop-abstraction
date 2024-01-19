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
        public bool isAccountActive;
        public bool isAdmin;
    }
    public class UserAccountManagement
    {
        private List<User> users;

        public UserAccountManagement() {
            users = new List<User>();
            CreateAdminAccount("admin", "admin@example.com", "adminPassword");
        }

        private void CreateAdminAccount(string username, string email, string password) {
            CreateAccount(username, email, password);
            ChangeAccountActiveState(username, true);
            SetOrRemoveAdminFlag(username, true);
        }

        private void SetOrRemoveAdminFlag(string username, bool state) {
            foreach (User tmp in users)
            {
                if (tmp.userName.Equals(username))
                {
                    tmp.isAdmin = state;
                }
            }
        }

        public void CreateAccount(string userName, string email, string password) {
            
            try {
                if (isValidEmail(email)) {
                    if (isValidPassword(password)) {
                        User newUser = new User {
                            userName = userName,
                            email = email,
                            password = password,
                            isAccountActive = false,
                            isAdmin = false
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
                if (tmp.userName.Equals(userName)) {
                    return tmp.isAccountActive;
                }
            }
            return false;
        }

        public void ChangeAccountActiveState(string userName, bool state) {
            foreach (User tmp in users){
                if (tmp.userName.Equals(userName)){
                    tmp.isAccountActive = state;
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

        public bool isAdmin(string adminUserName) {
            foreach (User tmp in users){
                if (tmp.userName.Equals(adminUserName)){
                    if (tmp.isAdmin) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}