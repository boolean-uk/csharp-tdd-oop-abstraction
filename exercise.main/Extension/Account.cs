namespace exercise.main.Extension
{
    public class Account
    {
        private string _email;
        private string _password;
        public bool IsEnabled { get; set; }
        public Account(string email, string password)
        {
            bool validEmail = IsValidEmail(email);
            bool validPassword = IsValidPassword(password);
            if (validEmail && validPassword)
            {
                Console.WriteLine("Account succesfully created!");
                _email = email;
                _password = password;
            }
            else
            {
                throw new Exception("Email or password is invalid. Please try again.");
            }
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains('@');
        }

        public bool LogIn(string email, string password)
        {
            return IsEnabled && _email.Equals(email) && _password.Equals(password);
        }
    }
}