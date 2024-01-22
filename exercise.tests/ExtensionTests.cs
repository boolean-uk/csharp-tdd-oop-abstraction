using exercise.main.AccountManager;
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
        public void FirstTest()
        {
            //Checking if an account can be created
            AccManager test = new();

            string result2 = test.CreateAccount("monkey@hotmail.com", "bananasareawesome");

            Assert.That(result2, Is.EqualTo("Account created"));
            Assert.IsTrue(test.accounts.Any());
        }
        [Test]
        public void SecondTest()
        {
            //Checking if we get the "Wrong password" message
            AccManager test = new();

            string result = test.CreateAccount("monkey@hotmail.com", "banana");
            Assert.That(result, Is.EqualTo("Wrong password"));

            string result2 = test.CreateAccount("monkey@hotmail.com", "bananasareawesome");
            Assert.That(result2, Is.EqualTo("Account created"));
        }
        [Test]
        public void ThirdTest()
        {
            //Checking if we get the "Wrong email" message
            AccManager test = new();

            string result = test.CreateAccount("testsomething", "bananasareawesome");

            Assert.That(result, Is.EqualTo("Wrong email"));

        }
        [Test]
        public void FourthTest()
        {
            //Check if you can enable an account with the manager
            AccManager test = new();

            test.CreateAccount("test@something", "bananasareawesome");

            Manager testm = new();

            testm.EnableAccount(test.accounts[0]);
            Assert.IsTrue(test.accounts[0].getEnabled());
        }

        [Test]
        public void FifthTest()
        {
            //Checking the status of an account
            AccManager test = new();

            test.CreateAccount("test@something", "hahahahaha");
            Assert.IsFalse(test.accounts[0].getEnabled());
        }
    }
}
