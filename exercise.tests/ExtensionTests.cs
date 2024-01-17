using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void CreateUser()
        {
            User user = new User("test", "Valid@Email", "123456789");

            Assert.That(user.Name, Is.EqualTo("test"));
            Assert.That(user.Email, Is.EqualTo("Valid@Email"));
            Assert.IsFalse(user.Enabled);


        }

        [TestCase("1", "Invalid password")]
        [TestCase("123456789", "Password is OK.")]

        public void FailPassword(string password, string ExpectedResult)
        {
            User user = new User("test", "Valid@Email", password);
            Assert.That(user.GetPasswordStatus(), Is.EqualTo(ExpectedResult));



        }

        [Test]
        public void AccountsDisbaledByDefault()
        {
            User user = new User("test", "Valid@Email", "123456789");

            Assert.IsFalse(user.Enabled);
        }

        [Test]
        public void LoginAsDisabledUser()
        {
            User user = new User("test", "Valid@Email", "123456789");

            string res = user.Login("123456789");

            Assert.That(res, Is.EqualTo("Account is disabled."));

        }

        [Test]
        public void LoginAsEnabledUser()
        {
            User user = new User("test", "Valid@Email", "123456789");

            user.ToggleEnabled();
            string res = user.Login("123456789");

            Assert.That(res, Is.EqualTo("Success!"));

        }

    }



}
