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
        User user;

        [SetUp]
        public void Setup( ) 
        {
            user = new User("user@user.com", "password");
        }

        [Test]
        public void TestGetEmail()
        {
            Assert.That(user.Email, Is.EqualTo("user@user.com"));
        }

        [Test]
        public void TestSetEmail()
        {
            user.Email = "new@user.com";
            Assert.That(user.Email, Is.EqualTo("new@user.com"));
        }

        [Test]
        public void TestSetInvalidEmail ()
        {
            Assert.Throws<ArgumentException>(() => user.SetEmail("new!user.com"), "Invalid email");
            Assert.That(user.Email, Is.EqualTo("user@user.com"));
        }

        [Test]
        public void GetPassword()
        {
            Assert.That(user.Password, Is.EqualTo("password"));
        }

        [Test]
        public void TestSetPassword()
        {
            user.Password = "newpassword";
            Assert.That(user.Password, Is.EqualTo("newpassword"));
        }

        [Test]
        public void TestSetInvalidPassword()
        {
            Assert.Throws<ArgumentException>(() => user.SetPassword("wrong"), "Password should be at least 8 characters long");
            Assert.That(user.Password, Is.EqualTo("password"));
        }

        [Test]
        public void TestGetIsEnabled()
        {
            Assert.That(user.IsEnabled, Is.EqualTo(false));
        }

        [Test]
        public void TestSetIsEnabled()
        {
            user.SetIsEnabled(true);
            Assert.That(user.IsEnabled, Is.EqualTo(true));
        }

    }
}
