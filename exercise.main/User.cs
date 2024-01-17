using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _enabled;

        public User(string email, string password)
        {
            _enabled = false;
            try
            {
                SetEmail(email);
                SetPassword(password);
            }
            catch
            {
                throw;
            }

        }

        public bool Enabled { get => _enabled; }

        public void SetEnabled()
        {
            _enabled = true;
        }

        public void SetDisabled()
        {
            _enabled = false;
        }

        private void SetEmail(string email)
        {
            if (!email.Contains("@")) { throw new Exception("Invalid Email: Please include @"); }
            _email = email;
        }

        private void SetPassword(string password)
        {
            if (password.Length < 8) { throw new Exception("Invalid Password: Minimum of 8 characters required"); }
            _password = password;
        }
    }
}
