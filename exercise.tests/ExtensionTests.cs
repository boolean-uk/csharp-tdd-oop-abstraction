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
        public Account _account = new Account();
        [Test]
        public void createAccountTest1()
        {
            string result = _account.CreateAccount("eliassoprani.net", "blahblah");
            Assert.AreEqual("email needs @", result);
        }

        [Test]
        public void createAccountTest2()
        {
            string result = _account.CreateAccount("elias@soprani.net", "asd");
            Assert.AreEqual("password can not be less than 8", result);
        }

        [Test]
        public void createAccountTest3()
        {
            string result = _account.CreateAccount("elias@soprani.net", "longerthan8chars");
            Assert.AreEqual("account created", result);
        }

        [Test]
        public void canLogInTest1()
        {
            bool result = _account.CanLogIn();
            Assert.IsFalse(result);
        }

        [Test]
        public void canLogInTest2()
        {
            _account.SetEnabled();
            bool result = _account.CanLogIn();
            Assert.IsTrue(result);
        }
    }
}
