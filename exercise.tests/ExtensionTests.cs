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
        [TestCase("name","qwertyu")]
        [TestCase("name@", "qwertyu")]
        [TestCase("name@", "qwededewdedwrtyu")]
        public void createUser(string username,string password)
        {
            User user = new User(username,password);
            

            Assert.That(user, Is.Not.Null);
            Assert.That(user.Username, Is.EqualTo(username));
            
        }
    }
}
