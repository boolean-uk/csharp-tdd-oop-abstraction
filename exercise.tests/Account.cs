

namespace exercise.main
{
    public class Account 
    {   // List of users
        private Dictionary<string , bool> _Users = new Dictionary<string, bool>();



        public bool makeAccount(string userName, string passWord)
        {
            //Perform the check for valid password:
            if (checkPassword(passWord))
            {
                _Users.Add(userName, false);
                return true;
            }
            else { 
                return false;
            }
        }

        public bool checkPassword(string passWord)
        {
            if (passWord.Length > 8)
            {  //If the condition is not met -> false
                return false;
            }
            return true;
        }
    }
}