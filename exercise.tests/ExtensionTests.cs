using NUnit.Framework;
using static exercise.main.Extension;

namespace exercise.tests
{
    [TestFixture]
    public class UserAccountTests
    {
        [Test]
        public void AccountCreationValidCredentials()
        {
            Assert.DoesNotThrow(() => new UserAccount("user@example.com", "password123"));
        }

        [Test]
        public void AccountCreationInvalidEmail()
        {
            Assert.Throws<ArgumentException>(() => new UserAccount("userexample.com", "password123"));
        }

        [Test]
        public void AccountCreationInvalidPassword()
        {
            Assert.Throws<ArgumentException>(() => new UserAccount("user@example.com", "pass"));
        }

        [Test]
        public void NewAccountShouldBeDisabled()
        {
            var account = new UserAccount("user@example.com", "password123");
            Assert.IsFalse(account.CanLogin());
        }

        [Test]
        public void EnablingAccountShouldAllowLogin()
        {
            var account = new UserAccount("user@example.com", "password123");
            account.EnableAccount();
            Assert.IsTrue(account.CanLogin());
        }

        [Test]
        public void DisabledAccountShouldNotAllowLogin()
        {
            var account = new UserAccount("user@example.com", "password123");
            Assert.IsFalse(account.CanLogin());
        }
    }
}
