using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using tdd_oop_abstraction.CSharp.Main;


namespace Boolean.CSharp.Test
{
    public class CoreTests
    {
        public CoreTests()
        {

        }

        [TestCase("Stavros_1996@windowslive.com", "123456789", "Account has been created successfully")]
        [TestCase("Stavros_1996windowslive.com", "123456789", "Account has not been created")]
        [TestCase("Stavros_1996@windowslive.com", "123", "Account has not been created")]
        public void CreateAccountTest(string email, string password, string expected)
        {
            Account account = new Account();
            User user = new User("User");
            string result = account.CreateAccount(user, email, password);

            Assert.AreEqual(result, expected);   
        }

        [Test]
        public void EnableAccountTest()
        {
            Account account = new Account();
            User user = new User("User");
            User admin = new User("Admin");

            account.CreateAccount(user, "Stavros_1996@windowslive.com", "123456789");
            bool result = account.EnableAccount(admin);

            Assert.IsTrue(result);
            Assert.AreEqual(account.IsActivated, true);
        }

        [Test]
        public void AbleToLogInTest()
        {
            Account account = new Account();
            User user = new User("User");
            User admin = new User("Admin");

            account.CreateAccount(user, "Stavros_1996@windowslive.com", "123456789");
            bool result = account.AbleToLogIn(user);

            Assert.IsFalse(result);
            Assert.AreEqual(account.IsActivated, false);
        }
    }
}