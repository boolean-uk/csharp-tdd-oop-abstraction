
namespace exercise.main.Extension
{
    public class Account
    {   // List of users
        protected Dictionary<string, bool> _Users = new Dictionary<string, bool>();



        public bool makeAccount(string userName, string passWord)
        {
            //Perform the check for valid password and userName:
            if (checkPassword(passWord) && checkUser(userName))
            {
                _Users.Add(userName, false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkPassword(string passWord)
        {
            if (passWord.Length > 8)
            {  //If the condition is not met -> false
                return true;
            }
            return false;
        }

        public bool checkUser(string userName)
        {
            if (userName.Contains('@'))
            {
                return true;
            }
            return false;

        }

        public bool getAccountStatus(string userName)
        {
            return _Users[userName];
        }
    }
}