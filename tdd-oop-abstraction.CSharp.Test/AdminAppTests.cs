using tdd_oop_abstraction.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_oop_abstraction.CSharp.Test
{
    [TestFixture]
    public class AdminAppTests
    {
        [Test]
        public void CreateAccountTest()
        {
            AdminApp app = new AdminApp();
            string result = app.CreateAccount("foo@bar.baz", "1234567890");
            Assert.IsTrue(result == "account created");
        }

        [Test]
        public void DontCreateAccountWithInvalidPasswordTest()
        {
            AdminApp app = new AdminApp();
            string result = app.CreateAccount("foo@ar.baz", "1234");
            Assert.IsTrue(result == "invalid password");
        }

        [Test]
        public void DontCreateAccountWithInvalidEmailTest()
        {
            AdminApp app = new AdminApp();
            string result = app.CreateAccount("foo.bar.baz", "1234567890");
            Assert.IsTrue(result == "invalid email");
        }
    }
}
