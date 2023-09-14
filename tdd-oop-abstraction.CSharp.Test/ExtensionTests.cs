using tdd_oop_abstraction.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_oop_abstraction.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void SigningUp()
        {
            string email = "user@example.com";
            string password = "SecurePwd117";

            UserAccount user = new UserAccount(email, password);

            Assert.AreEqual(email, user.Email);
            Assert.IsFalse(user.IsEnabled);
        }

        [Test]
        public void SigningUpWithInvalidEmail()
        {
            string email = "invalid-email";
            string password = "SecurePwd117";

            Assert.Throws<ArgumentException>(() => new UserAccount(email, password));
        }

        [Test]
        public void SigningUpWithInvalidPassword()
        {
            string email = "user@example.com";
            string password = "Pwd117"; 

            Assert.Throws<ArgumentException>(() => new UserAccount(email, password));
        }

        [Test]
        public void EnablingAccount()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");

            user.EnableAccount();

            Assert.IsTrue(user.IsEnabled);
        }

        [Test]
        public void DisablingAccount()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");
            user.EnableAccount(); 

            user.DisableAccount();

            Assert.IsFalse(user.IsEnabled);
        }

        [TestCase("SecurePwd117", "SecurePwd117", true)]
        [TestCase("SecurePwd117", "IncorrectPwd", false)]
        public void ValidatingPassword(string initialPassword, string testPassword, bool expectedValidation)
        {
            UserAccount user = new UserAccount("user@example.com", initialPassword);

            bool isValid = user.ValidatePassword(testPassword);

            Assert.AreEqual(expectedValidation, isValid);
        }

        [Test]
        public void SigningInWithEnabledAccount()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");
            user.EnableAccount(); 
            string correctEmail = "user@example.com";
            string correctPassword = "SecurePwd117";

            bool signInResult = user.SignIn(correctEmail, correctPassword);

            Assert.IsTrue(signInResult);
        }

        [Test]
        public void SigningInWithDisabledAccount()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");
            string correctEmail = "user@example.com";
            string correctPassword = "SecurePwd117";

            Assert.IsFalse(user.SignIn(correctEmail, correctPassword));
        }

        [Test]
        public void SigningInWithInvalidEmail()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");
            user.EnableAccount(); 
            string incorrectEmail = "invalid-email";
            string correctPassword = "SecurePwd117";

            bool signInResult = user.SignIn(incorrectEmail, correctPassword);

            Assert.IsFalse(signInResult);
        }

        [Test]
        public void SigningInWithInvalidPassword()
        {
            UserAccount user = new UserAccount("user@example.com", "SecurePwd117");
            user.EnableAccount(); 
            string correctEmail = "user@example.com";
            string incorrectPassword = "IncorrectPwd";

            bool signInResult = user.SignIn(correctEmail, incorrectPassword);

            Assert.IsFalse(signInResult);
        }
    }
}