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
        [TestCase("klara.hotmaill.com", "Invalid emal")]
        [TestCase("klara@hotmaill", "Valid emal")]
        public void SetEmails(string email, string expected)
        {
            string result = account.SetEmail(email);
            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase("qwertyuio", "Valid password")]
        [TestCase("qwertyui", "Invalid password")]
        [TestCase("qwer", "Valid password")]
        public void SetPasswords(string password, string expected)
        {
            string result = account.SetEmail(password);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void AccountDisabled()
        {
            account.DisableAccount(account);
            bool disabled = account.CanLogin(account);
            Assert.That(false, Is.EqualTo(disabled));
        }
    }
}