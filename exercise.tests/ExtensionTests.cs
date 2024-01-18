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
            Assert.That(user.CheckEmail("xrectyv@cfgvhb"), Is.EqualTo(true));
        }

        [Test]
        public void UserSetEmailNoAt()
        {
            Assert.That(user.SetEmail("sxdrcftvgyhuj"), Is.EqualTo("invalid email"));
            Assert.That(user.CheckEmail("sxdrcftvgyhuj"), Is.EqualTo(false));
        }

        [Test]
        public void UserSetPassword()
        {
            Assert.That(user.SetPassword("rctvybunim"), Is.EqualTo(String.Empty));
            Assert.That(user.CheckPassword("rctvybunim"), Is.EqualTo(true));
        }

        [Test]
        public void UserSetPasswordShort()
        {
            Assert.That(user.SetPassword("rctvybm"), Is.EqualTo("invalid password"));
            Assert.That(user.CheckPassword("rctvybm"), Is.EqualTo(false));
        }

        [Test]
        public void UserDisabled()
        {
            Assert.That(user.CheckStatus(), Is.EqualTo(false));
        }

        [Test]
        public void UserEnabled()
        {
            admin.toggleUser(user);
            Assert.That(user.CheckStatus(), Is.EqualTo(true));
        }


    }
}
