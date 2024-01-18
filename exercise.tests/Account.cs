
namespace exercise.main
{
    public class Account
    {   // List of users
        Dictionary<string, bool> _Users = new Dictionary<string, bool>();



        public bool makeAccount(string userName, string passWord)
        {
           _Users.Add(userName, true);
            return true;
        }
    }
}