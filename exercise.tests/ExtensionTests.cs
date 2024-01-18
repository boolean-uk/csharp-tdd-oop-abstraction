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
        [Test]
        public void SholdNotBePossibleToCreateUserWithInvalidPassword()
        {
            string email = "elsalos@icloud.com";
            string password = "1234567";
            string response = "";
            try
            {
                User user = new User(email, password);
            } catch (Exception ex)
            {
                response = ex.Message;
            }
            
            Assert.That(response, Is.EqualTo("invalid password"));
        }
        [Test]
        public void SholdNotBePossibleToCreateUserWithInvalidEmail()
        {
            string email = "elsalosicloud.com";
            string password = "12345678";
            string response = "";
            try
            {
                User user = new User(email, password);
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            Assert.That(response, Is.EqualTo("invalid email"));
        }
        [Test]
        public void SholdBePossibleToCreateUserWithValidEmailAndPassword()
        {
            User user = new User("elsalos@icloud.com", "12345678");
            Assert.That(user.Email, Is.EqualTo("elsalos@icloud.com"));
        }
        [Test]
        public void SholdNotLoginIfDisabled()
        {
            User user = new User("elsalos@icloud.com", "12345678");
            bool loggedIn = user.Login();

            Assert.IsFalse(loggedIn);
        }
        [Test]
        public void SholdLoginIfEnabled()
        {
            User user = new User("elsalos@icloud.com", "12345678");
            user.Enable();
            bool loggedIn = user.Login();

            Assert.IsTrue(loggedIn);
        }
    }
}
