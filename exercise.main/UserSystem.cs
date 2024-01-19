using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserSystem
    {
        public List<User> userList = new List<User>();
        public string errorMessage = "Unknown Error.";

        public void createUser(string email, string password)
        {
            if (!email.Contains('@'))
            {
                errorMessage = "Invalid E-mail.";
            } else if (password.Length < 8)
            {
                errorMessage = "Invalid Password.";
            } else
            {
                userList.Add(new User(email, password));
            }
        }

        public void toggleUser(User user)
        {
            if (userList.Contains(user))
            {
                user.Status = !user.Status;
            }
            else
            {
                errorMessage = $"There is no user with the e-mail {user.Email}";
            }
        }
        public void toggleUser(string user)
        {
            if (userList.Any(x => x.Email == user))
            {
                var item = userList.Where(x => user == x.Email).FirstOrDefault();
                userList.Add(item);
            } else
            {
                errorMessage = $"There is no user with the e-mail {user}";
            }
        }
        public void signIn(User user)
        {
            if (user.Status == false)
            {
                errorMessage = "Account not enabled.";
            } else
            {
                user.SignedIn = true;
            }
        }
    }
}
