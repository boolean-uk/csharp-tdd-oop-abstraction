using exercise.main.AccountManager;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void CreateUserTest()
        {
            User user = new User("Testuser@test.com", "HenrikPassword");

            Assert.That(user.Email, Is.EqualTo("Testuser@test.com"));
            Assert.IsFalse(user.IsEnabled);
        }
        [Test]
        public void EnableAccount()
        {
            User user = new User("Testuser@test.com", "HenrikPassword");
            user.EnableAccount();

            Assert.IsTrue(user.IsEnabled);
        }

        [Test]
        public void LoginWithPassword()
        {
            User user = new User("Testuser@test.com", "HenrikPassword");
            user.EnableAccount();

            Assert.That(user.TryLogin("HenrikPassword"), Is.True);
        }
    }
}