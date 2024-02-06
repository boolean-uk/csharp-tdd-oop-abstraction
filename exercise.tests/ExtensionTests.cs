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
        User user2; 

        [SetUp]
        public void Setup( ) 
        {
            user = new User("user@user.com", "password");
        }

        [Test]
        public void TestGetEmail()
        {
            Assert.That(user.getEmail(), Is.EqualTo("user@user.com"));
        }

        [Test]
        public void TestSetEmail()
        {
            string newEmail = user.setEmail("new@user.com");
            Assert.That(user.getEmail(), Is.EqualTo("new@user.com"));
            Assert.That(newEmail, Is.EqualTo("Email succesfully set"));
        }

        [Test]
        public void TestSetInvalidEmail ()
        {
            string newEmail = user.setEmail("new!user.com");
            Assert.That(newEmail, Is.EqualTo("Invalid email"));
            Assert.That(user.getEmail(), Is.EqualTo("user@user.com"));
        }

        [Test]
        public void GetPassword()
        {
            Assert.That(user.getPassword(), Is.EqualTo("password"));
        }

        [Test]
        public void TestSetPassword()
        {
            string newPassword = user.setPassword("newpassword");
            Assert.That(user.getPassword(), Is.EqualTo("newpassword"));
            Assert.That(newPassword, Is.EqualTo("Password succesfully set"));
        }

        [Test]
        public void TestSetInvalidPassword()
        {
            string newPassword = user.setPassword("wrong");
            Assert.That(newPassword, Is.EqualTo("Password should be at least 8 characters long"));
            Assert.That(user.getPassword(), Is.EqualTo("password"));
        }

        [Test]
        public void TestGetIsEnabled()
        {
            Assert.That(user.getIsEnabled(), Is.EqualTo(false));
        }

        [Test]
        public void TestSetIsEnabled()
        {
            user.setIsEnabled(true);
            Assert.That(user.getIsEnabled(), Is.EqualTo(true));
        }

    }
}
