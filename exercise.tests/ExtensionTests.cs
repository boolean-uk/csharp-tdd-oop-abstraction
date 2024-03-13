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
        [TestCase("PassWord", "testEmail@test.com")]
        [TestCase("", "testEmail@test.com")]
        [TestCase("PassWord", "")]
        public void Tests1(string passWord, string email)
        {
            Account account = new Account(passWord, email);

            Assert.That(account.UserPassword, Is.EqualTo(passWord));
            Assert.That(account.UserEmailAddress, Is.EqualTo(email));
            Assert.That(account.AccountRole, Is.EqualTo(UserRole.User));
            Assert.That(account.AccountEnabeled, Is.EqualTo(false));
        }

        [Test]
        [TestCase("PassWord", "testEmail@test.com")]
        [TestCase("", "testEmail@test.com")]
        [TestCase("PassWord", "")]
        public void Tests2(string password, string email)
        {
            Account account = new Account(password, email, UserRole.Admin);

            Assert.That(account.UserPassword, Is.EqualTo(password));
            Assert.That(account.UserEmailAddress, Is.EqualTo(email));
            Assert.That(account.AccountRole, Is.EqualTo(UserRole.Admin));
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
            webPage.createAcount("PassWord", "Admin@test.com", UserRole.Admin);
            webPage.createAcount("PassWord", "testEmail@test.com");
            webPage.LogIn("PassWord", "Admin@test.com");
            webPage.enableAccount("testEmail@test.com");

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

            webPage.createAcount("PassWord", "Admin@test.com", UserRole.Admin);
            webPage.createAcount("PassWord", "testEmail@test.com");
            webPage.LogIn("PassWord", "Admin@test.com");
            string test = webPage.enableAccount("testEmail@test.com");

            Assert.That(test, Is.EqualTo("Account was enabeled"));

        }
        [Test]
        public void Tests11()
        {
            //enableAccount
            webPage.createAcount("PassWord", "Admin@test.com");
            webPage.createAcount("PassWord", "testEmail@test.com");
            webPage.LogIn("PassWord", "Admin@test.com");
            string test = webPage.enableAccount("testEmail@test.com");

            Assert.That(test, Is.EqualTo("Not a valid Admin verification"));
        }
        [Test]
        public void Tests12()
        {
            //enableAccount
            webPage.createAcount("PassWord", "Admin@test.com", UserRole.Admin);
            webPage.createAcount("PassWord", "testEmail@test.com");
            webPage.LogIn("PassWord", "Admin@test.com");
            string test = webPage.enableAccount("WrongTestEmail@test.com");

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
            Assert.That(test.AccountRole, Is.EqualTo(webPage.Accounts["testEmail@test.com"].AccountRole)); 
            Assert.That(test.UserEmailAddress, Is.EqualTo(webPage.Accounts["testEmail@test.com"].UserEmailAddress));

        }

    }
}
