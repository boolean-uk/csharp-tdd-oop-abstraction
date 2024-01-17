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
            bool shouldWork = user.createAccount("some@email.com", "somePasswordOfLengthGreaterThan8");
            bool shouldNotWorkTooShortPassword = user2.createAccount("some@email.com", "somePwd");
            bool shouldNotWorkNoAt = user3.createAccount("noemail.com", "somePasswordOfLengthGreaterThan8");

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
            user.createAccount("@3", "124u12894124eff");

            //execute
            string email = user.GetEmail();

            //verify
            Assert.That(email, Is.EqualTo("@3"));
        }
    }
}
