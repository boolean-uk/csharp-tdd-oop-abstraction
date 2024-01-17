using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class AccountTests
    {
        UserAccount account;

        [SetUp]
        public void SetUp()
        {
            account = new UserAccount();
        }

        [TestCase("klara@hotmaill.com", "Valid email")]
        [TestCase("klara.hotmaill.com", "Invalid email")]
        [TestCase("klara@hotmaill", "Valid email")]
        public void SetEmails(string email, string expected)
        {
            string result = account.SetEmail(email);
            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase("qwertyuio", "Valid password")]
        [TestCase("qwertyui", "Valid password")]
        [TestCase("qwer", "Invalid password")]
        public void SetPasswords(string password, string expected)
        {
            string result = account.SetPassword(password);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void AccountDisabled()
        {
            account.DisableAccount();
            bool disabled = account.CanLogin();
            Assert.That(false, Is.EqualTo(disabled));
        }

        [Test]
        public void AccountEnabled()
        {
            account.EnableAccount();
            bool disabled = account.CanLogin();
            Assert.That(true, Is.EqualTo(disabled));
        }
    }
}