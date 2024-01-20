using exercise.main;
using static exercise.main.User;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {

        [TestCase("email@test.com", "password", "success")]
        [TestCase("email@test.com", "pass", "invalid password, must be more than 7 characters")]
        public void TestUserPassword(string email, string password, string returnString)
        {
            User user = new User(email, password);
            Assert.AreEqual(user.CreatePassword(password), returnString);
        }

        [TestCase("email@test.com", "password", "success")]
        [TestCase("email", "password", "invalid email, does not contain @")]
        public void TestSetEmail(string email, string password, string returnString)
        {
            User user = new User(email, password);
            Assert.AreEqual(user.SetEmail(email), returnString);
        }

        [Test]
        public void AccountDisabledDefault()
        {
            User user = new User("email@test.com", "123456789");
            Assert.That(user.AccountEnabled(), Is.EqualTo(AccountStatus.DISABLED));
        }

        [Test]
        public void AccountEnabled()
        {
            User user = new User("email@test.com", "123456789");
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.ENABELD));

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.ENABELD));
        }

        [Test]
        public void AccountDisable()
        {
            User user = new User("email@test.com", "123456789");
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));
            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));
        }

        [Test]
        public void NoEmail()
        {
            User user = new User("email", "123456789");
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));

            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));
        }

        [Test]
        public void NoPassword()
        {
            User user = new User("email@test.com", "1");
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));

            user.EnableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));

            user.DisableAccount();
            Assert.That(user.AccountEnabled, Is.EqualTo(AccountStatus.DISABLED));
        }
    }
}
