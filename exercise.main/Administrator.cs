using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Administrator
    {
        private List<User> _users;
        private List<User> _verifiedUsers;
        public Administrator(List<User> users, List<User> verifiedUsers)
        {
            _users = users;
            _verifiedUsers = verifiedUsers;
        }

        public void login(User user)
        {
            if (_verifiedUsers.Contains(user)) { Console.WriteLine("Login successful"); }
        }

        public void AddUser(User user)
        {
            if (_users.Contains(user))
            {
                Console.WriteLine("Username or email already exists");
            }
            else
            {
                _users.Add(user);
            }
        }


        public bool verifyUser(User user)
        {
            return user.validEmail() && user.validPassword();
        }

        public void AddVerifiedUser(User user)
        {
            if (_verifiedUsers.Contains(user))
            {
                Console.WriteLine("User already exists");

            }

            else if (verifyUser(user))
            {
                _verifiedUsers.Add(user);
            }
            else
            {
                Console.WriteLine("Password or email not correct");
            }
        }
    }
}
