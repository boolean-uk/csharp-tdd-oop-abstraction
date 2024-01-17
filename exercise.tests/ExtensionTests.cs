using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NUnit.Framework;
using exercise.main;

namespace exercise.tests
{
  
    [TestFixture]
    public class ExtensionTests
    {
        private UserAccountManagement userAccountManagement;

        [SetUp]
        public void SetUp() {
            userAccountManagement = new UserAccountManagement();
        }

        [Test]
        public void CreateAccount_ValidData_AccountCreated()
        {
            // Arrange
            string userName = "testUser";
            string email = "test@example.com";
            string password = "strongPwd";

            // Act
            userAccountManagement.CreateAccount(userName, email, password);

            // Assert
            Assert.False(userAccountManagement.isAccountActive(userName));
            
        }

        [Test]
        public void CreateAccount_InvalidEmail_ExceptionThrown()
        {
            // Arrange
            string userName = "testUser";
            string invalidEmail = "invalidEmail";

            // Act & Assert
            Assert.Throws<Exception>(() => userAccountManagement.CreateAccount(userName, invalidEmail, "password"));
        }

        [Test]
        public void CreateAccount_ShortPassword_ExceptionThrown()
        {
            // Arrange
            string userName = "testUser";
            string validEmail = "test@example.com";
            string shortPassword = "123";

            // Act & Assert
            Assert.Throws<Exception>(() => userAccountManagement.CreateAccount(userName, validEmail, shortPassword));
        }

        [Test]
        public void ChangeAccountState_UserExists_AccountStateUpdated()
        {
            // Arrange
            string userName = "testUser66";
            userAccountManagement.CreateAccount(userName, "test@example.com", "strongPwd");

            // Act
            userAccountManagement.ChangeAccountState(userName, true);

            // Assert
            Assert.True(userAccountManagement.isAccountActive(userName));
        }

        [Test]
        public void ChangeAccountState_UserDoesNotExist_NoExceptionThrown()
        {
            // Arrange
            string nonExistingUser = "nonExistingUser";

            // Act & Assert
            Assert.DoesNotThrow(() => userAccountManagement.ChangeAccountState(nonExistingUser, true));
        }
    }
}
