using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class UserManager
    {
        public List<User> Users { get; set; } = new List<User>();



        public void CreateAccount(string email, string password)
        {
            if (!email.ToLower().Contains('@'))
            {
                Console.WriteLine("Email does not contain a @");

            }
            if(password.Length < 8)
            {
                Console.WriteLine("Password must contain 8 characters or more");
            }
            if(email.ToLower().Contains('@') && password.Length >= 8)
            {
                Users.Add(new User(email, password));
                Console.WriteLine($"Account has been created for {email}");
            }
        }

        public bool CanLogin(string email)
        {
            bool result = false;
            foreach(var user in Users)
            {
                if (user.Status == "Enabled")
                {
                    result = true;
                }
            }
            return result;
        }


    }
}
