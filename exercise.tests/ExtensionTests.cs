using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {

        [TestCase("email@test.com","password","success")]
        [TestCase("email@test.com", "pass", "invalid password")]
        public void TestUserPassword(string email, string password, string returnString) {
            User user = new User(email,password);
            Assert.AreEqual(user.CreatePassword(password), returnString);        
        }

        [TestCase("email@test.com","password", "success")]
        [TestCase("email", "password","invalid email")]
        public void TestSetEmail(string email, string password, string returnString)
        {
            User user = new User(email, password);
            Assert.AreEqual(user.SetEmail(email), returnString);
        }

        [Test]
        public void AccountDisabledDefault()
        {
            User user = new User("email@test.com", "123456789");
            Assert.That(user.AccountEnabled(), Is.False);
        }

        [Test]
        public void AccountEnabled() {
            User user = new User("email@test.com", "123456789");
            Assert.That(user.AccountEnabled, Is.False);

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.True);

            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.False);
        }

        [Test]
        public void NoEmail()
        {
            User user = new User("email", "123456789");
            Assert.That(user.AccountEnabled, Is.False);

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.False);

            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.False);
        }

        [Test]
        public void NoPassword()
        {
            User user = new User("email@test.com", "1");
            Assert.That(user.AccountEnabled, Is.False);

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.False);

            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.False);
        }
    }
}
