


namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _isActive;
        public bool CreateAccount(string email, string password)
        {
            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid email");
                return false;
            }
            else if (password.Length < 8)
            {
                Console.WriteLine("Invalid password");
                return false;
            }
            _email = email;
            _password = password;
            _isActive = false;
            Console.WriteLine("Account created successfully");
            return true;
        }

        public string GetEmail()
        {
            return _email;
        }

        public bool IsAccountActive()
        {
            return _isActive;
        }

        public void ActivateAccount()
        {
            _isActive = true;
        }

        public bool CanLogin()
        {
            if (_isActive)
            {
                Console.WriteLine("Can log in");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot log in");
                return false;
            }
        }
    }
}
