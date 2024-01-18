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
        private AccountRegister register;
        private AdminAccount admin; 

        [SetUp]
        public void SetUp()
        {
            admin = new AdminAccount();
            register = new AccountRegister(); 
        }

        [Test]
        public void CreatingUserAccountSuccessful()
        {
            string expected = "New user was successfully created"; 

            Assert.That(register.CreateUser("test@test.com", "password"), Is.EqualTo(expected));
        }

        [Test]
        public void CreatingUserAccountInvalidEmail ()
        {
            string expected = "Invalid email"; 

            Assert.That(register.CreateUser("testtest.com", "password"), Is.EqualTo(expected));
        }

        [Test]
        public void CreatingUserAccountInvalidPassword ()
        {
            string expected = "Invalid password"; 

            Assert.That(register.CreateUser("test@test.com", "pass"), Is.EqualTo(expected));
        }

        [Test]
        public void IsUserAccountDisabled()
        {
            UserAccount testUser = new UserAccount("test@test.no", "password123");
            bool enabled = testUser.CanUserLogin(); 

            Assert.That(enabled, Is.False);
        }

        [Test]
        public void IsUserAccountEnabled()
        {
            UserAccount testUser = new UserAccount("test@test.no", "password123");
            admin.EnableUserAccount(testUser);
            bool enabled = testUser.CanUserLogin(); 

            Assert.That(enabled, Is.True);
        }
    }
}
