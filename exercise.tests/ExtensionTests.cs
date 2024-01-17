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
            bool shouldNotWorkTooShortPassword = user.createAccount("some@email.com", "somePwd");
            bool shouldNotWorkNoAt = user.createAccount("noemail.com", "somePasswordOfLengthGreaterThan8");

            //verify
            Assert.That(shouldWork, Is.True);
            Assert.That(shouldNotWorkTooShortPassword, Is.False);
            Assert.That(shouldNotWorkNoAt, Is.False);
        }
    }
}
