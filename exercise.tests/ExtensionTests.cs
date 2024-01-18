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
        private UserAccount myUserAccount;

        [Test]
        //Test to create account with valid email/password
        public void createAccountTest()
        {
            myUserAccount = new UserAccount("valid@ex.com", "validpassword");
            Assert.AreEqual("valid@ex.com", myUserAccount.Email);
            Assert.AreEqual("validpassword", myUserAccount.Password);
            Assert.IsFalse(myUserAccount.IsEnabled); // Account should be disabled by default
        }
        [Test]
        //Create Account with invalid Email
        public void invalidEmailTest()
        {

            Assert.Throws<ArgumentException>(() => new UserAccount("invalidEmail.com", "validpassword"));
        }

        [Test]
        //Create Account with invalid password
        public void invalidPasswordTest()
        {

            Assert.Throws<ArgumentException>(() => new UserAccount("valid@ex.com", "invapwd"));
        }

        [Test]
        //Enable Account
        public void enableAccountTest()
        {
            myUserAccount = new UserAccount("valid@example.com", "validpassword");
            myUserAccount.EnableAccount();
            Assert.IsTrue(myUserAccount.IsEnabled);
        }
        [Test]
        //Disable Account
        public void disableAccountTest()
        {
            myUserAccount = new UserAccount("valid@example.com", "validpassword");
            myUserAccount.EnableAccount();
            myUserAccount.DisableAccount();
            Assert.IsFalse(myUserAccount.IsEnabled);
        }
    }
}
