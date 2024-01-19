// UserAccount.cs
namespace exercise.main
{
    public class UserAccount
    {
        private string email;
        private string password;
        private bool isEnabled;

        public UserAccount(string email , string password)
        {
            if(!IsValidEmail(email))
            {
                throw new Exception("Invalid email");
            }

            if(!IsValidPassword(password))
            {
                throw new Exception("Invalid password");
            }

            this.email = email;
            this.password = password;
            this.isEnabled = false;
        }

        public bool Enable()
        {
            if(!this.isEnabled)
            {
                this.isEnabled = true;
                return true;
            }
            return false;
        }

        public bool Disable()
        {
            if(this.isEnabled)
            {
                this.isEnabled = false;
                return true;
            }
            return false;
        }

        public bool CanLogin()
        {
            return this.isEnabled;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }
    }
}
