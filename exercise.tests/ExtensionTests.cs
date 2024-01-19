using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension _userManager;
        private User admin;

        [SetUp]
        public void SetUp() {
            admin = new User("admin@admin.com", "admin", Role.ADMIN);
            _userManager = new Extension(admin);
        }


        [TestCase ("test@email.com", "12345678")]
        public void CanCreateUser(string email, string password)
        {
            string actual = _userManager.CreateUser(email, password);
            StringAssert.Contains("User Created!", actual);
        }

        [TestCase ("test.email.com")]
        [TestCase ("wrong")]
        public void CanNotCreateUserWithInvalidEmail(string email) {
            string actual = _userManager.CreateUser(email, "12345678");
            Assert.That(actual, Is.EqualTo("invalid email"));
        }

        [TestCase ("1234")]
        [TestCase ("wrong")]
        [TestCase ("@£!2")]
        public void CanNotCreateUserWithInvalidPassword(string password) {
            string actual = _userManager.CreateUser("email@email.com", password);
            Assert.That("invalid password", Is.EqualTo(actual));
        }

        [Test]
        public void TestCreateUserNull()
        {
            string actual = _userManager.CreateUser("", "");
            StringAssert.Contains("Can Not Be Empty!", actual);
        }

        public void TestChangeStatus()
        {
            _userManager.CreateUser("valid@email.com", "12345678");
            bool status = _userManager.EnableUser(admin, "valid@email.com", true);
             Assert.That(status, Is.EqualTo(true));
        }

        public void TestChangeStatusNonAdmin()
        {
            _userManager.CreateUser("valid@email.com", "12345678");
            User user = new User("test@test.com", "12745234343");
            bool status = _userManager.EnableUser(user, "valid@email.com", true);
             Assert.That(status, Is.EqualTo(false));
        }
    }
}
