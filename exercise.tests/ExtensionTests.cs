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
        // User Story 1: User Account Creation
        [Test]
        public void User_AccountCreationWithValidEmailAndPassword()
        {
            // Arrange
            string validEmail = "test@example.com";
            string validPassword = "validPassword123";

            // Act
            var user = new User(validEmail, validPassword);

            // Assert
            Assert.AreEqual(validEmail, user.Email);
            Assert.AreEqual(AccountStatus.Disabled, user.Status);
            Assert.AreEqual(validPassword, user.Password);
        }

        // User Story 2: User Account Validation for email
        [Test]
        public void User_AccountCreationWithInvalidEmail()
        {
            // Arrange
            string invalidEmail = "invalidemail";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new User(invalidEmail, "validPassword123"));
        }

        // User Story 3: User Account Validation for password
        [Test]
        public void User_AccountCreationWithInvalidShortPassword()
        {
            // Arrange
            string validEmail = "test@example.com";
            string invalidShortPassword = "pass";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new User(validEmail, invalidShortPassword));
        }

        // User Story 4: User Account Activation/Deactivation
        [Test]
        public void User_EnableAccountShouldSetAccountStatusToEnabled()
        {
            // Arrange
            var user = new User("test@example.com", "validPassword123");

            // Act
            user.Enable();

            // Assert
            Assert.AreEqual(AccountStatus.Enabled, user.Status);
        }

        [Test]
        public void User_DisableAccountShouldSetAccountStatusToDisabled()
        {
            // Arrange
            var user = new User("test@example.com", "validPassword123");
            user.Enable();

            // Act
            user.Disable();

            // Assert
            Assert.AreEqual(AccountStatus.Disabled, user.Status);
        }

        // User Story 5: User Account Status Checking
        [Test]
        public void User_IsEnabled_WhenUserIsEnabled_ShouldReturnTrue()
        {
            // Arrange
            var user = new User("test@example.com", "validPassword123");
            user.Enable();

            // Act & Assert
            Assert.IsTrue(user.IsEnabled());
        }

        [Test]
        public void User_IsEnabled_WhenUserIsDisabled_ShouldReturnFalse()
        {
            // Arrange
            var user = new User("test@example.com", "validPassword123");

            // Act & Assert
            Assert.IsFalse(user.IsEnabled());
        }
    }
}
