using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string email;
        private string password;
        private bool disabled;


        public User(string email, string password)
        {
            if (password.Length < 8)
            {
                throw new Exception("invalid password");
            } else
            {
                this.password = password;
            }
            if (!email.Contains("@")){
                throw new Exception("invalid email");
            } else
            {
                this.email = email;
            }
            disabled = true;
        }

        public string Email { get { return email; } }
        public bool Disabled { get { return disabled; } }
        public void Enable()
        {
            this.disabled = false;
        }
        public bool Login()
        {
            return !disabled;
        }
    }
}
