// ExtensionTests.cs
using exercise.main;

namespace exercise.tests
{
    public class ExtensionTests
    {
        private UserAccount _userAccount;

        [SetUp]
        public void Setup()
        {
            _userAccount = new UserAccount("test@example.com" , "password123");
        }

        [Test]
        public void TestUserAccountCreation()
        {
            var email = "test@example.com";
            var password = "password123";

            var userAccount = new UserAccount(email , password);

            Assert.IsFalse(userAccount.CanLogin());
        }

        [Test]
        public void TestUserAccountEnableDisable()
        {
            Assert.IsTrue(_userAccount.Enable());
            Assert.IsTrue(_userAccount.CanLogin());

            Assert.IsFalse(_userAccount.Enable()); // It should return false as the account is already enabled

            Assert.IsTrue(_userAccount.Disable());
            Assert.IsFalse(_userAccount.CanLogin());

            Assert.IsFalse(_userAccount.Disable()); // It should return false as the account is already disabled
        }

        [Test]
        public void TestInvalidEmail()
        {
            var email = "invalid_email";
            var password = "password123";

            Assert.Throws<Exception>(() => new UserAccount(email , password));
        }

        [Test]
        public void TestInvalidPassword()
        {
            var email = "test@example.com";
            var password = "short";

            Assert.Throws<Exception>(() => new UserAccount(email , password));
        }
    }
}
