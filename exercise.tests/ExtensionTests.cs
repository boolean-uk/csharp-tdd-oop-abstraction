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
        WebPage webPage;
        [SetUp]
        public void SetUp()
        {
            webPage = new WebPage();
        }


        //Account tests
        [Test]
        public void Tests1()
        {
            Account account = new Account("PassWord", "testEmail@test.com");

            Assert.That(account.UserPassword, Is.EqualTo("PassWord"));
            Assert.That(account.UserEmailAddress, Is.EqualTo("testEmail@test.com"));
            Assert.That(account.AcountRoll, Is.EqualTo(Account.roll.User));
            Assert.That(account.AccountEnabeled, Is.EqualTo(false));
        }

        [Test]
        public void Tests2()
        {
            Account account = new Account("PassWord", "testEmail@test.com", "ADMIN");

            Assert.That(account.UserPassword, Is.EqualTo("PassWord"));
            Assert.That(account.UserEmailAddress, Is.EqualTo("testEmail@test.com"));
            Assert.That(account.AcountRoll, Is.EqualTo(Account.roll.Admin));
            Assert.That(account.AccountEnabeled, Is.EqualTo(true));
        }

        //WebPage Tests
        [Test]
        public void Tests3()
        {
            //createAccount
            string test = webPage.createAcount("PassWord", "testEmail@test.com");

            Assert.That(test, Is.EqualTo("New account was made"));
            Assert.That(webPage.Accounts.Count, Is.EqualTo(1));
            
        }
        [Test]
        public void Tests4()
        {
            //createAccount
            string test = webPage.createAcount("P", "testEmail@test.com");

            Assert.That(test, Is.EqualTo(":P: is not a valid password (it needs at least 8 characters)"));

            Assert.That(webPage.Accounts.Count, Is.EqualTo(0));
        }
        [Test]
        public void Tests5()
        {
            //createAccount
            string test = webPage.createAcount("PassWord", "testEmail(a)test.com");

            Assert.That(test, Is.EqualTo(":testEmail(a)test.com: is not a valid email (a valid email needs to contain an @ )"));

            Assert.That(webPage.Accounts.Count, Is.EqualTo(0));
        }
        [Test]
        public void Tests6()
        {
            //createAccount
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.createAcount("PassWord", "testEmail@test.com");

            Assert.That(test, Is.EqualTo("There is already an account with that email"));

            Assert.That(webPage.Accounts.Count, Is.EqualTo(1));
        }


        [Test]
        public void Tests7()
        {

            //LogIn
            webPage.createAcount("PassWord", "Admin@test.com", "ADMIN");
            webPage.createAcount("PassWord", "testEmail@test.com");
            webPage.enableAccount("testEmail@test.com", "Admin@test.com");

            string test = webPage.LogIn("PassWord", "testEmail@test.com");



            Assert.That(test, Is.EqualTo("You are now loged in :)"));
            Assert.That(webPage.Accounts["testEmail@test.com"].AccountEnabeled, Is.EqualTo(true));

        }
        [Test]
        public void Tests8()
        {
            //LogIn
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.LogIn("PassWord", "testEmail@test.com");

            Assert.That(test, Is.EqualTo("Your account needs to be verified by an Admin to be able to log in"));
            Assert.That(webPage.Accounts["testEmail@test.com"].AccountEnabeled, Is.EqualTo(false));

        }
        [Test]
        public void Tests9()
        {
            //LogIn
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.LogIn("PassWord", "WrongEmail@test.com");

            Assert.That(test, Is.EqualTo("Wrong password or Email"));
        }
        [Test]
        public void Tests10()
        {
            // enableAccount

            webPage.createAcount("PassWord", "Admin@test.com", "ADMIN");
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.enableAccount("testEmail@test.com", "Admin@test.com");

            Assert.That(test, Is.EqualTo("Account was enabeled"));

        }
        [Test]
        public void Tests11()
        {
            //enableAccount
            webPage.createAcount("PassWord", "Admin@test.com");
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.enableAccount("testEmail@test.com", "Admin@test.com");

            Assert.That(test, Is.EqualTo("Not a valid Admin verification"));
        }
        [Test]
        public void Tests12()
        {
            //enableAccount
            webPage.createAcount("PassWord", "Admin@test.com");
            webPage.createAcount("PassWord", "testEmail@test.com");
            string test = webPage.enableAccount("WrongTestEmail@test.com", "Admin@test.com");

            Assert.That(test, Is.EqualTo("Not a valid email. No account is using it."));
        }
        [Test]
        public void Test13()
        {
            //GetAccount

            webPage.createAcount("PassWord", "testEmail@test.com");
            Account test = webPage.GetAccount("testEmail@test.com");

            Assert.That(test.UserPassword, Is.EqualTo(webPage.Accounts["testEmail@test.com"].UserPassword));
            Assert.That(test.AccountEnabeled, Is.EqualTo(webPage.Accounts["testEmail@test.com"].AccountEnabeled));
            Assert.That(test.AcountRoll, Is.EqualTo(webPage.Accounts["testEmail@test.com"].AcountRoll)); 
            Assert.That(test.UserEmailAddress, Is.EqualTo(webPage.Accounts["testEmail@test.com"].UserEmailAddress));

        }

    }
}
