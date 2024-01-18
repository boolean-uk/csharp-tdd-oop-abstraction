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

        AdminUser admin;
        PublicUser user;

        [SetUp]
        public void SetUp()
        {
            admin = new();
            user = new();
        }

        [Test]
        public void UserSetEmail()
        {
            Assert.That(user.SetEmail("xrectyv@cfgvhb"), Is.EqualTo(String.Empty));
            Assert.That(user._email, Is.EqualTo("xrectyv@cfgvhb"));
        }

        [Test]
        public void UserSetEmailNoAt()
        {
            Assert.That(user.SetEmail("sxdrcftvgyhuj"), Is.EqualTo("invalid email"));
            Assert.That(user._email, Is.EqualTo(String.Empty));
        }

        [Test]
        public void UserSetPassword()
        {
            Assert.That(user.SetPassword("rctvybunim"), Is.EqualTo(String.Empty));
            Assert.That(user._password, Is.EqualTo("rctvybunim"));
        }

        [Test]
        public void UserSetPasswordShort()
        {
            Assert.That(user.SetPassword("rctvybm"), Is.EqualTo("invalid password"));
            Assert.That(user._password, Is.EqualTo(String.Empty));
        }

        [Test]
        public void UserDisabled()
        {
            Assert.That(user._enabled, Is.EqualTo(false));
        }

        [Test]
        public void UserEnabled()
        {
            admin.toggleUser(user);
            Assert.That(user._enabled, Is.EqualTo(true));
        }


    }
}
