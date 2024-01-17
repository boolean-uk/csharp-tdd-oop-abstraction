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
        public void TestWrongEmail()
        {
            User user;
            Assert.Throws<Exception>(() => user = new User("testemail", "testpassword"));
        }

        [Test]
        public void TestWrongPassword()
        {
            User user;
            Assert.Throws<Exception>(() => user = new User("test@email", "pass"));
        }

        [Test]
        public void TestCorrectUser()
        {
            User user;
            Assert.DoesNotThrow(() => user = new User("test@email", "password"));
            user = new User("test@email", "password");
            Assert.That(user.Enabled, Is.False);
        }

        [Test]
        public void TestSetEnabled()
        {
            User user = new User("test@email", "password");
            user.SetEnabled();
            Assert.That(user.Enabled, Is.True);
        }

        [Test]
        public void TestSetDisabled()
        {
            User user = new User("test@email", "password");
            user.SetEnabled();
            Assert.That(user.Enabled, Is.True);
            user.SetDisabled();
            Assert.That(user.Enabled, Is.False);
        }
    }
}
