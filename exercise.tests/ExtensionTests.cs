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
        public void TestsInvalidPassword()
        {
            var ex = Assert.Throws<ArgumentException>(() => new UserAccount("hotmail@hotmail.com", "1234567"));
            Assert.That(ex.Message, Is.EqualTo("You must provide a password of at least 8 characters"));
        }

        [Test]
        public void TestsInvalidEmail() 
        {
            var ex = Assert.Throws<ArgumentException>(() => new UserAccount("hotmail.hotmail.com", "12345678"));
            Assert.That(ex.Message, Is.EqualTo("Invalid email"));
        }

        public void TestValidAccountCreation()
        {
            UserAccount user = new UserAccount("hotmail@hotmail.com", "12345678");
            Assert.IsInstanceOf(UserAccount, user);
        }

        public void TestUserAccountDisabledOnCreate() 
        {
            UserAccount user = new UserAccount("hotmail@hotmail.com", "12345678");
            Assert.That(user.enabled == false);
        }

    }
}
