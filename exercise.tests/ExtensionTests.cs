using exercise.main.Accounts;
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
        [TestCase("ABCDE", true)] // Too short
        [TestCase("ABCDEFGH", false)] // Valid 
        [TestCase("ABABABABABABABABABABABAB", false)] // Kinda long, but fine
        public void PasswordValidityTest(string password, bool shouldGiveError)
        {
            // Arrange
            string email = "valid@email.abc";

            // Act
            if (!shouldGiveError)
            {
                Assert.DoesNotThrow(() => new User(email, password));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new User(email, password));
            }

        }

        [Test]
        [TestCase("my@email.site", false)]
        [TestCase("Hello.My.Name.Is.Very.Long@email.site", false)]
        [TestCase("ThisIsMyNameNotMyEmail", true)]
        public void EmailValidityTest(string email, bool shouldGiveError)
        {
            // Arrange
            string password = "abcdefgh";

            // Act
            if (!shouldGiveError) 
            {
                Assert.DoesNotThrow(() => new User(email, password));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new User(email, password));
            }
            

        }

        [Test]
        public void CheckAccountStatusTest() 
        {
            // Assert
            Account user1 = new User("a@b.com", "abcdefgh");
            Account user2 = new User("a@b.com", "abcdefgh");
            Account sysAd = new SystemAdministrator("admin@this.site", "qwertyuiop");

            // Act
            bool preStatus1 = user1.IsEnabled();
            user1.EnableAccount(user1);
            bool postStatus1 = user1.IsEnabled();

            bool preStatus2 = user2.IsEnabled();
            user2.EnableAccount(sysAd);
            bool postStatus2 = user2.IsEnabled();

            // Assert
            Assert.That(sysAd.IsEnabled, Is.True);

            Assert.That(preStatus1, Is.False);
            Assert.That(postStatus1, Is.False);

            Assert.That(preStatus2, Is.False);
            Assert.That(postStatus2, Is.True);

        }

        public void CanLoginUserTest() 
        {
            // Assert
            Account user = new User("a@b.com", "abcdefgh");
            Account sysAd = new SystemAdministrator("admin@this.site", "qwertyuiop");

            // Act
            bool preEnabled = user.CanLogIn();
            user.EnableAccount(sysAd);
            bool postEnabled = user.CanLogIn();

            // Assert
            Assert.That(preEnabled, Is.False);
            Assert.That(postEnabled, Is.True);
        }
    }
}
