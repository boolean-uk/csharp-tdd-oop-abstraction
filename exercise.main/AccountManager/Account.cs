namespace exercise.main.AccountManager
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _isEnabled;

        public User(string email, string password)
        {
            ValidateEmail(email);
            ValidatePassword(password);

            _email = email;
            _password = password;
            _isEnabled = false;
        }

        private void ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                throw new ArgumentException("Password must be minimum 8 characters.");
            }
        }

        private void ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ArgumentException("Email must contain @. ");
            }
        }

        public string Email
        {
            get { return _email; }
        }


        public bool IsEnabled
        {
            get { return _isEnabled; }
        }

        public void EnableAccount()
        {
            _isEnabled = true;
        }

        public bool TryLogin(string enteredPassword)
        {

            if (_isEnabled && enteredPassword == _password)
            {
                return true;
            }

            return false;
        }
    }
}