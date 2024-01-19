using exercise.main.Extension;
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
        public void createAccount()
        {
            // arrange 
            Users user = new Users();
            string email = "example@hotmail.com";
            string password = "longerthaneight";
            string response;

            // act
            bool result = user.CreateAccount(email, password, out response);

            // assert
            Assert.That(result, Is.True);
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void invalidPassword() 
        {
            // arrange
            Users users = new Users();
            string email = "example@hotmail.com";
            string password = "hello";
            string response;

            // act
            bool result = users.CreateAccount(email, password, out response);

            // assert
            Assert.That(result, Is.False);
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void invalidEmail() 
        {
            // arrange

            Users users = new Users();
            string email = "examplehotmail.com";
            string password = "longerthaneight";
            string response;

            // act
            bool result = users.CreateAccount(email, password, out response);

            // assert
            Assert.That(result, Is.False);
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void userIsNotEnabled() 
        {
            // arrange
            Users user = new Users();
            string email = "example@hotmail.com";
            string password = "longerthaneight";
            string response;
            user.CreateAccount(email, password, out response);

            // act
            UserInformation userInformation = user.GetUser(email);
            bool result = userInformation._enabled;

            // assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void userIsEnabled()
        {
            // arrange
            Users user = new Users();
            string email = "example@hotmail.com";
            string password = "longerthaneight";
            string response;
            user.CreateAccount(email, password, out response);
            user.EnableAccount(email);

            // act
            UserInformation userInformation = user.GetUser(email);
            bool result = userInformation._enabled;

            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void userCannotLogin()
        {
            // arrange
            Users user = new Users();
            string email = "example@hotmail.com";
            string password = "longerthaneight";
            string response;
            user.CreateAccount(email, password, out response);           

            // act
            UserInformation userInformation = user.GetUser(email);
            bool result = user.login(email, password, out response);

            // assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void userCanLogin()
        {
            // arrange
            Users user = new Users();
            string email = "example@hotmail.com";
            string password = "longerthaneight";
            string response;
            user.CreateAccount(email, password, out response);
            user.EnableAccount(email);

            // act
            UserInformation userInformation = user.GetUser(email);
            bool result = user.login(email, password, out response);

            // assert
            Assert.That(result, Is.True);
        }
    }
}
