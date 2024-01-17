using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _user = new();
        }

        [Test]
        public void UserCanCreateAccount()
        {
            bool accountCreated = _user.CreateAccount("test@test.com", "totallySecurePassword");
            Assert.That(accountCreated, Is.True);
        }
    }
}
