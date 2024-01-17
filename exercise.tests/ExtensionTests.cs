using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void TestCreateUser()
        {
            //setup
            User user = new();
            User user2 = new();
            User user3 = new();

            //execute
            bool shouldWork = user.CreateAccount("some@email.com", "somePasswordOfLengthGreaterThan8");
            bool shouldNotWorkTooShortPassword = user2.CreateAccount("some@email.com", "somePwd");
            bool shouldNotWorkNoAt = user3.CreateAccount("noemail.com", "somePasswordOfLengthGreaterThan8");

            //verify
            Assert.That(shouldWork, Is.True);
            Assert.That(shouldNotWorkTooShortPassword, Is.False);
            Assert.That(shouldNotWorkNoAt, Is.False);
        }

        [Test]
        public void TestGetEmail()
        {
            //setup
            User user = new();
            user.CreateAccount("@3", "124u12894124eff");

            //execute
            string email = user.GetEmail();

            //verify
            Assert.That(email, Is.EqualTo("@3"));
        }

        [Test]
        public void TestIsDisabledByDefault()
        {
            //setup
            User user = new();
            user.CreateAccount("@3", "124u12894124eff");

            //execute
            bool isAccountActive = user.IsAccountActive();

            //verify
            Assert.That(isAccountActive, Is.False);
        }

        [Test]
        public void TestCanEnableAccount()
        {
            //setup
            User user = new();
            user.CreateAccount("@3", "124u12894124eff");

            //execute
            bool shouldNotBeActive = user.IsAccountActive();
            user.SetActive();
            bool shouldBeActive = user.IsAccountActive();

            //verify
            Assert.That(shouldNotBeActive, Is.False);
            Assert.That(shouldBeActive, Is.True);
        }

        [Test]
        public void TestLogin()
        {
            //setup
            User user = new();
            user.CreateAccount("@3", "124u12894124eff");

            //execute
            bool shouldNotLogIn = user.CanLogin();
            user.SetActive();
            bool shouldLogIn = user.CanLogin();

            //verify
            Assert.That(shouldNotLogIn, Is.False);
            Assert.That(shouldLogIn, Is.True);
        }
    }
}
