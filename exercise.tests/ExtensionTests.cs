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
        [TestCase("ABCDE", "invalid password")] // Too short
        [TestCase("ABCDEFGH", "")] // Valid 
        [TestCase("ABABABABABABABABABABABAB", "")] // Kinda long, but fine
        public void PasswordValidityTest(string password, string expectedOutput)
        {
            // Arrange
            string email = "valid@email.abc";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Account user = new User(email, password);
            sw.Close();
            string output = sw.ToString();
            output = output.Replace("\r\n", ""); // If line endings remove them

            // Assert
            Assert.That(output, Is.EqualTo(expectedOutput));

            // Restore
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        }

        [Test]
        [TestCase("my@email.site", "")]
        [TestCase("Hello.My.Name.Is.Very.Long@email.site", "")]
        [TestCase("ThisIsMyNameNotMyEmail", "invalid email")]
        public void EmailValidityTest(string email, string expectedOutput)
        {
            // Arrange
            string password = "abcdefgh";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            User user = new User(email, password);
            string output = sw.ToString();
            output = output.Replace("\r\n", ""); // If line endings remove them

            // Assert
            Assert.That(output, Is.EqualTo(expectedOutput));

            // Restore
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
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
