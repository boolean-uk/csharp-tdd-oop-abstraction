using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        private User _user;
        string _email = "test@test.com";
        string _password = "totallySecurePassword";

        [SetUp]
        public void SetUp()
        {
            _user = new();
        }

        [Test]
        public void UserCanCreateAccount()
        {
            bool accountCreated = _user.CreateAccount(_email, _password);
            Assert.That(accountCreated, Is.True);
        }

        [Test]
        public void UserCantLoginNotEnabledTest()
        {

            _user.CreateAccount(_email, _password);
            Assert.That(_user.LogIn(_email, _password), Is.False);
        }

        [Test]
        public void AdministratorCanEnableAccount()
        {
            _user.CreateAccount(_email, _password);
            Assert.That(_user.LogIn(_email, _password), Is.False);
            Administrator admin = new();
            admin.EnableAccount(_user.Account);
            Assert.That(_user.LogIn(_email, _password), Is.True);
        }
    }
}
