using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Extension;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        private Accounts accounts;
        private string adminEmail;
        private string userEmail;
        private string highlySecurePassword;

        [SetUp]
        public void SetUp()
        {
            accounts = new Accounts();
            adminEmail = "boss@account.com";
            userEmail = "user@account.com";
            highlySecurePassword = "12345678";
            Account admin = new AdminAccount(adminEmail, highlySecurePassword);
            Account user = new UserAccount(userEmail, highlySecurePassword);
            accounts.Add(admin);
            accounts.Add(user);
        }

        [Test]
        public void CreateUserTest()
        {
            Assert.That(accounts.AccountList.Count == 2);
            UserAccount user = (UserAccount)accounts.Get(userEmail);
            Assert.That(user.IsEnabled == false);
        }

        [TestCase("not an email", "12345678")]
        [TestCase(".", "12345678")]

        public void InvalidEmailTest(string email, string password)
        {
            UserAccount user;
            Assert.That(() => user = new UserAccount(email, password), Throws.TypeOf<InvalidOperationException>().With.Message.Contains("Invalid email"));
        }

        [TestCase("valid@email.com", "1234567")]
        [TestCase("valid@email.com", "1")]

        public void InvalidPasswordTest(string email, string password)
        {
            UserAccount user;
            Assert.That(() => user = new UserAccount(email, password), Throws.TypeOf<InvalidOperationException>().With.Message.Contains("Invalid password"));
        }

        [Test]
        public void ValidLoginTest()
        {
            AdminAccount admin = (AdminAccount)accounts.Get(adminEmail);
            Login login;
            Assert.DoesNotThrow(() => login = new Login(admin, highlySecurePassword));
        }

        [Test]
        public void InvalidLoginTest()
        {
            AdminAccount admin = (AdminAccount)accounts.Get(adminEmail);
            string wrongPassword = "ILikeBaloons";
            Login adminLogin;
            Assert.Throws<InvalidOperationException>(() => adminLogin = new Login(admin, wrongPassword));
            UserAccount user = (UserAccount)accounts.Get(userEmail);
            Assert.That(user.IsEnabled == false);
            Login userLogin;
            Assert.Throws<InvalidOperationException>(() => userLogin = new Login(user, highlySecurePassword));
        }

        [Test]
        public void UserEnableDisableTest()
        {
            UserAccount user = (UserAccount)accounts.Get(userEmail);
            AdminAccount admin =(AdminAccount)accounts.Get(adminEmail);
            Login adminLogin = new Login(admin, highlySecurePassword);
            Assert.DoesNotThrow(() => user.Enable(adminLogin));
            Assert.That(user.IsEnabled == true);
            Login userLogin;
            Assert.DoesNotThrow(() => userLogin = new Login(user, highlySecurePassword));
            userLogin = new Login(user, highlySecurePassword);
            string anotherUserEmail = "user2@accounts.com";
            UserAccount anotherUser = new UserAccount(anotherUserEmail, highlySecurePassword);
            Assert.Throws<UnauthorizedAccessException>(() => anotherUser.Enable(userLogin));
            Assert.DoesNotThrow(() => user.Disable(adminLogin));
        }
    }
}
