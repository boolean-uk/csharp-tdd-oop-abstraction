using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public abstract class Account
    {
        private string email;
        private string password;

        public Account(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string email, string password)
        {
            if (MeetsEmailPolicy(email))
            {
                if (MeetsPasswordPolicy(password))
                {
                    this.email = email;
                    this.password = password;
                }
                else throw new InvalidOperationException("Invalid password.");
            }
            else throw new InvalidOperationException("Invalid email adress");
        }

        public bool IsCorrectPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool MeetsEmailPolicy(string email)
        {
            throw new NotImplementedException();
        }

        public bool MeetsPasswordPolicy(string password)
        {  
            throw new NotImplementedException();
        }

        public string Email { get => email; }

    }

}
