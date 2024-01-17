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
        Extension system;
        Admin admin;
        [SetUp] 
        public void setupTest()
        {
            system = new Extension();
            admin = new Admin();
        }
        [Test]
        public void enableUserTest()
        {
            User user = new User("password123", "me@domain.com");
            admin.enableUser(user);
            Assert.IsTrue(user.canLogin());
        }
        [Test]
        public void checkUserTest()
        {
            Assert.True(system.addUser("1password2", "you@domain.comn"));
        }
        [Test]
        public void canLoginTest()
        {
            User user = new User("password123", "me@domain.com");
            admin.enableUser(user);
            Assert.IsTrue(user.canLogin());
        }
    }
}
