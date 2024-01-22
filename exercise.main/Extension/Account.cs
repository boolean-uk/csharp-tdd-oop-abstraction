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
            Register(email, password);
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
            else throw new InvalidOperationException("Invalid email address.");
        }

        public bool IsCorrectPassword(string password)
        {
            return password == this.password;
        }

        public bool MeetsEmailPolicy(string email)
        {
            return email.Contains('@');
        }

        public bool MeetsPasswordPolicy(string password)
        {
            return password.Length >= 8;
        }

        public string Email { get => email; }

    }

}
