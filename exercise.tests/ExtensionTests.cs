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
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }

        [Test]
        public void Tests()
        {
            Assert.Pass();
        }

        [Test]
        public void PassWordValid()
        {
            string res1 = _user.passWordCreate("asonroeinoit");

            Assert.AreEqual(res1, "success!");

            string res2 = _user.passWordCreate("as");

            Assert.AreEqual(res2, "invalid!");

        }

        [Test]
        public void EmailValid()
        {
            string res1 = _user.EmailCreate("asonroeinoit@gmail.com");

            Assert.AreEqual(res1, "success!");

            string res2 = _user.EmailCreate("as");

            Assert.AreEqual(res2, "invalid!");

        }

        [Test]
        public void NewDisabled()
        {
            User us1 = new User();

            Assert.IsFalse(us1.getStatus());

            us1.setAccountEnabled();

            Assert.IsTrue(us1.getStatus());

            us1.setAccountInabled();

            Assert.IsFalse(us1.getStatus());
        }

        [Test]
        public void CanUserLogin()
        {
            User us1 = new User();

            Assert.IsFalse(us1.getStatus());

            us1.setAccountEnabled();

            Assert.IsTrue(us1.getStatus());

        }
    }
}
