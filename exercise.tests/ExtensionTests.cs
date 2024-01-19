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
        [Test]
        public void UserAccountCreateTest()
        {
            UserAccount user = new UserAccount("name", "password", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            int userCount = admin.GetUserCount();

            Assert.That(userCount, Is.EqualTo(1));

        }

        [Test]
        public void ValidatePasswordTest()
        {
            UserAccount user = new UserAccount("name", "passwor", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            int userCount = admin.GetUserCount();

            Assert.That(userCount, Is.EqualTo(0));
        }

        [Test]
        public void ValidateEmailTest()
        {
            UserAccount user = new UserAccount("name", "password", "emailemail.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            int userCount = admin.GetUserCount();

            Assert.That(userCount, Is.EqualTo(0));
        }

        [Test]
        public void UserAccountIsDisabledTest()
        {
            UserAccount user = new UserAccount("name", "password", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            int enabledUserCount = admin.GetEnabledUserCount();

            Assert.That(enabledUserCount, Is.EqualTo(0));
        }

        [Test]
        public void AdminEnableAccountTest()
        {
            UserAccount user = new UserAccount("name", "password", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            admin.EnableUser(user);
            int enabledUserCount = admin.GetEnabledUserCount();

            Assert.That(enabledUserCount, Is.EqualTo(1));
        }


        [Test]
        public void AdminDisableAccountTest()
        {
            UserAccount user = new UserAccount("name", "password", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            admin.EnableUser(user);
            admin.DisableUser(user);
            int enabledUserCount = admin.GetEnabledUserCount();

            Assert.That(enabledUserCount, Is.EqualTo(0));
        }


        [Test]
        public void LoginTest()
        {
            UserAccount user = new UserAccount("name", "password", "email@email.com");
            Administrator admin = new Administrator();

            admin.AddUser(user);
            admin.EnableUser(user);
            bool loggedIn = admin.LogIn("name", "password");

            Assert.That(loggedIn, Is.EqualTo(true));
        }
    }
}
