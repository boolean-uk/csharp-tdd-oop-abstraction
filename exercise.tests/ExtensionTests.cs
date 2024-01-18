using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [TestCase("password", true)]
        [TestCase("nopass", false)]
        public void TestPassword(string pass, bool expected)
        {
            User user = new User();

            bool result = user.SetPassword(pass);

            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase("nigel@boolean.com", true)]
        [TestCase("nigelboolean.com", false)]
        public void TestEmail(string email, bool expected)
        {
	        User user = new User();

	        bool result = user.SetEmail(email);

	        Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestUserEnabled()
        {
	        User user = new User();
	        user.EnableUser();

	        bool result = user.IsEnabled();

	        Assert.IsTrue(result);
        }

        [Test]
        public void TestUserLogIn()
        {
	        User user = new User();
	        user.EnableUser();

	        bool result = user.LogIn();

	        Assert.IsTrue(result);
        }
	}
}
