using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        AccountSystem system;

        [SetUp]
        public void Setup()
        {
            system = new AccountSystem();
        }

        [Test]
        public void ShouldCreateAccount()
        {
            bool created = system.CreateAccount("test@gmail.com", "12345678");
            Assert.That(created, Is.True);
        }

        [Test]
        public void ShouldBeInvalidPassword()
        {
            bool created = system.CreateAccount("test@gmail.com", "123");
            Assert.That(created, Is.False);
        }

        [Test]
        public void ShouldBeInvalidEmail()
        {
            bool created = system.CreateAccount("testgmail.com", "123");
            Assert.That(created, Is.False);
        }

        [Test]
        public void ShouldBeDisabled()
        {
            Account account = new Account("test@gmail.com", "123");
            Assert.That(account.CanLogIn(), Is.False);
        }

        [Test]
        public void ShouldBeEnabled()
        {
            Account account = new Account("test@gmail.com", "123");
            system.ToggleAccount(account);
            Assert.That(account.CanLogIn(), Is.True);
        }

        [Test]
        public void CanLogIn()
        {
            Account account = new Account("test@gmail.com", "123");
            system.ToggleAccount(account);
            Assert.That(account.CanLogIn(), Is.True);
        }
    }
}
