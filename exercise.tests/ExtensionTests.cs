using exercise.main.UserAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        
        [TestCase("name@", "qwededewdedwrtyu")]
        [TestCase("name@", "qu")]
        [TestCase("name", "qudewdweswqdwqdqw")]
        public void createUser(string username,string password)
        {
            User user = new User();
            string Result = user.createAccount(username,password);
             
            Assert.That(password.Length >=8 && username.Contains("@"), Is.EqualTo(Result== "Account created"));
            Assert.That(password.Length < 8, Is.EqualTo(Result.Contains("Invalid password")==true));
            Assert.That(username.Contains("@")!=true, Is.EqualTo(Result.Contains("Invalid email") == true));
        }

        [TestCase]
        public void enableAccount()
        {
            User regular = new User();
            User regular1 = new User();
            AdminUser admin = new AdminUser();

            regular.EnableAccount(regular1);
            Assert.That(regular1.IsEnabled == false, Is.EqualTo(regular1.logIn()==false));
            admin.EnableAccount(regular1);
           Assert.That(regular1.IsEnabled == true, Is.EqualTo(regular1.logIn() == true));
        }
    }
}
