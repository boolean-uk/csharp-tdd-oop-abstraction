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
            admin = new User("admin@admin.com", "admin", "Admin");
            _userManager = new Extension(admin);
        }

        [Test]
        public void TestCreateUser()
        {
            string actual = _userManager.CreateUser("email@email.com", "12345678");
            StringAssert.Contains("User Created!", actual);
        }

        [Test]
        public void TestCreateUserNull()
        {
            string actual = _userManager.CreateUser("", "");
            StringAssert.Contains("Can Not Be Empty!", actual);
        }

        [TestCase ("Hej", "invalid email")]
        [TestCase ("Email@email.com", "User Created!")]
        public void TestValidEmail(string email, string expected)
        {
            string actual = _userManager.CreateUser(email, "12345678");
            StringAssert.Contains(expected, actual);
        }

        [TestCase ("12345678", "User Created!")]
        [TestCase ("1234", "invalid password")]
        public void TestValidPassword(string password, string expected)
        {
            string actual = _userManager.CreateUser("valid@email.com", password);
            StringAssert.Contains(expected, actual);
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
