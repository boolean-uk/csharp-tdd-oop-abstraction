


namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        public bool createAccount(string email, string password)
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
            Console.WriteLine("Account created successfully");
            return true;
        }

        public string GetEmail()
        {
            return _email;
        }

        public bool IsAccountActive()
        {
            throw new NotImplementedException();
        }

        public void SetActive()
        {
            throw new NotImplementedException();
        }
    }
}
