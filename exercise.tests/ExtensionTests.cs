using exercise.main;
using NUnit.Framework;
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
        Extension system;
        Admin admin;
        [SetUp] 
        public void setupTest()
        {
            system = new Extension();
            admin = new Admin();
        }
        [Test]
        public void addUserTest()
        {
            User user1 = system.addUser("password123", "me@domain.com");
            User user2 = system.addUser("1password2", "you@domain.com");
            Assert.That(system.Users.Contains(user1));
            Assert.That(system.Users.Contains(user2));
        }
        [Test]
        public void enableUserTest()
        {
            User user = system.addUser("password123", "me@domain.com");
            admin.enableUser(user);
            Assert.IsTrue(user.canLogin());
        }
        [Test]
        public void checkUserTest()
        {
            User user = system.addUser("1password2", "you@domain.com");
            Assert.IsTrue(!user.canLogin());
            admin.enableUser(user);
            Assert.IsTrue(user.canLogin());
        }
        [Test]
        public void canLoginTest()
        {
            User user = new User("password123", "me@domain.com");
            User user2 = new User("TRACtoRman","tractor@yepp.pl");
            admin.enableUser(user);
            Assert.IsTrue(user.canLogin());
            Assert.IsFalse(user2.canLogin());
        }
    }
}
