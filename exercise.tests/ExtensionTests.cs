using exercise.main.Objects;
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
        public void CreateUser()
        {
            AccountManager test = new();

            string result2 = test.CreateAccount("test@something", "hahahahaha");
            Assert.AreEqual("Account created", result2);
            Assert.IsTrue(test.accounts.Any());
        }
        [Test]
        public void WrongPassword()
        {
            AccountManager test = new();

            string result = test.CreateAccount("test@something", "haha");
            Assert.AreEqual("Wrong password",result);
            string result2 = test.CreateAccount("test@something", "hahahahaha");
            Assert.AreEqual("Account created", result2);
        }
        [Test]
        public void WrongEmail()
        {
            AccountManager test = new();

            string result = test.CreateAccount("testsomething", "haha");
            Assert.AreEqual("Wrong email", result);
            
        }
        [Test]
        public void EnableAccount()
        {
            AccountManager test = new();

            test.CreateAccount("test@something", "hahahahaha");

            Manager testm = new();
            testm.EnableAccount(test.accounts[0]);
            Assert.IsTrue(test.accounts[0].getEnabled());
        }
        
        [Test]  
        public void GetAccountStatus() 
        {
            AccountManager test = new();

            test.CreateAccount("test@something", "hahahahaha");
            Assert.IsFalse(test.accounts[0].getEnabled());
        }
    }
}
