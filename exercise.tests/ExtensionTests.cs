using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void CreateUserTest()
        {
            User user = new User("Testuser@test.com", "BigBrainPassword");

            Assert.That(user.Email, Is.EqualTo("Testuser@test.com"));
            Assert.IsFalse(user.IsEnabled);
        }
        [Test]
        public void EnableAccount()
        {
            User user = new User("Testuser@test.com" , "BigBrainPassword");
            user.EnableAccount();

            Assert.IsTrue(user.IsEnabled);
        }

        [Test]
        public void LoginWithValidPassword()
        {
            User user = new User("Testuser@test.com", "BigBrainPassword");
            user.EnableAccount();

            Assert.That(user.TryLogin("BigBrainPassword"), Is.True);
        }

    }
}
