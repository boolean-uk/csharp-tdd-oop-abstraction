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
        
        [TestCase("eliassoprani.net", "blahblah", "email needs @")]
        [TestCase("elias@soprani.net", "asd", "password can not be less than 8")]
        [TestCase("elias@soprani.net", "longerthan8chars", "account created")]
        public void TestCreateAccount(string email, string password, string expected){
            string result = _account.CreateAccount(email, password);
            Assert.That(result, Is.EqualTo(expected));
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
