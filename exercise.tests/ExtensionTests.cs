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


        private UserAccount user;
        private string email;
        private string password;
        private string status;

        [SetUp]
        public void SetUp()
        {
            // Common setup code that runs before each test
            string email = "Test@test.com";
            string password = "longpassword";

            user = new UserAccount(email, password);
        }



        [Test]
        public void ValidUser()
        {
            // Arrange
            string validEmail = "test@test.com";
            string validPassword = "password123";

            // Act
            UserAccount user = new UserAccount(validEmail, validPassword);

            // Assert
            Assert.AreEqual(validEmail, user.GetEmail());
            Assert.AreEqual(validPassword, user.GetPassword());

            //testing that the default user is disabled
            Assert.That(user.IsEnabled, Is.False);
        }

        [Test]
        public void InvalidEmail()
        {
            // Arrange
            string invalidEmail = "test.test";
            string validPassword = "password123";

            Assert.Throws<ArgumentException>(() => new UserAccount(invalidEmail, validPassword),
            "Invalid email");
        }

        [Test]
        public void EmptyEmail()
        {
            // Arrange
            string emptyEmail = "";
            string validPassword = "password123";

            Assert.Throws<ArgumentException>(() => new UserAccount(emptyEmail, validPassword),
                        "Invalid email");
        }


        [Test]
        public void ShortPassword()
        {
            // Arrange
            string validEmail = "test@test.com";
            string shortPassword = "short";

            Assert.Throws<ArgumentException>(() => new UserAccount(validEmail, shortPassword),
            "Invalid password");
        }


        [Test]
        public void EnablingTest()
        {
            UserAccount userEnabled = new UserAccount("test@test.com", "password123");

            //check that default is disabled
            Assert.That(userEnabled.IsEnabled, Is.False);

            
            //enable and check it works
            userEnabled.enableAccount();
            Assert.That(userEnabled.IsEnabled, Is.True);

            //check nothing fais when enabling an already enabled account
            userEnabled.enableAccount();
            Assert.That(userEnabled.IsEnabled, Is.True);   
        }


        [Test]
        public void DisablingTest()
        {
            UserAccount userDisabled = new UserAccount("test@test.com", "password123");

            //check that default is disabled
            Assert.That(userDisabled.IsEnabled, Is.False);


            //enable and check it works
            userDisabled.enableAccount();
            Assert.That(userDisabled.IsEnabled, Is.True);

            //check disabling works
            userDisabled.disableAccount();
            Assert.That(userDisabled.IsEnabled, Is.False);


            //check nothing fais when disabling an already disabled account
            userDisabled.disableAccount();
            Assert.That(userDisabled.IsEnabled, Is.False);
        }

    }
}
