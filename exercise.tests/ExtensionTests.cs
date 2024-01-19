using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        /// <summary>
        /// I want my users to have to create a user account with an email address and a password.
        /// </summary>
        [Test, Order(1)]
        public void Test_01_CreateUser_Success()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();

            //Act
            string expectedResultS = system.CreateUserAccount("email@email.com", "password");
            string actualResultS = "User successfully created";
            bool expectedResultB = system.Accounts.Count > 0;
            bool actualResultB = true;

            //Assert
            Assert.That(expectedResultS, Is.EqualTo(actualResultS));
            Assert.That(expectedResultB, Is.EqualTo(actualResultB));
        }

        /// <summary>
        /// I want them to receive an "invalid password" message if they provide a password less than 8 characters in length.
        /// </summary>
        [Test, Order(2)]
        public void Test_02_CreateUser_Fail_Email()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();

            //Act
            string expectedResultS = system.CreateUserAccount("emailemail.com", "password");
            string actualResultS = "Error: Email does not contain an @";
            bool expectedResultB = system.Accounts.Count == 0;
            bool actualResultB = true;

            //Assert
            Assert.That(expectedResultS, Is.EqualTo(actualResultS));
            Assert.That(expectedResultB, Is.EqualTo(actualResultB));
        }

        /// <summary>
        /// I want them to receive an "invalid email" message if they provide an email address without an @ symbol in it.
        /// </summary>
        [Test, Order(3)]
        public void Test_03_CreateUser_Fail_Password()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();

            //Act
            string expectedResultS = system.CreateUserAccount("email@email.com", "word");
            string actualResultS = "Error: Password is less than 8 characters";
            bool expectedResultB = system.Accounts.Count == 0;
            bool actualResultB = true;

            //Assert
            Assert.That(expectedResultS, Is.EqualTo(actualResultS));
            Assert.That(expectedResultB, Is.EqualTo(actualResultB));
        }


        /// <summary>
        /// I want new accounts to be disabled by default until I manually set them as enabled.
        /// </summary>
        [Test, Order(4)]
        public void Test_04_SetEnabled()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();
            system.CreateUserAccount("email@email.com", "password");
            system.CreateUserAccount("admin@admin.com", "password", true);

            //Casting. Probably not a smart thing to do and if so, be cast inside CreateUserAccount().
            User user = (User)system.Accounts[0];
            Administrator admin = (Administrator)system.Accounts[1];

            //Act
            bool userDisabledByDefault = user.IsEnabled;
            admin.EnableAccount(user, true);
            bool userIsNowEnabled = user.IsEnabled;
            admin.EnableAccount(user, false);
            bool userIsDisabledAgain = user.IsEnabled;

            //Assert
            Assert.That(userDisabledByDefault, Is.EqualTo(false));
            Assert.That(userIsNowEnabled, Is.EqualTo(true));
            Assert.That(userIsDisabledAgain, Is.EqualTo(false));
        }

        [Test, Order(6)]
        public void Test_06_LogIn_Fail()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();
            system.CreateUserAccount("email@email.com", "password");

            //Casting. Probably not a smart thing to do and if so, be cast inside CreateUserAccount().
            User user = (User)system.Accounts[0];

            //Act
            bool expectedResultMethod = system.LogIn("email@email.com", "password");
            bool actualResultMethod = false;

            bool expectedResultIsLoggedIn = system.Accounts[0].IsLoggedIn;
            bool actualResultIsLoggedIn = false;

            //Assert
            Assert.That(expectedResultMethod, Is.EqualTo(actualResultMethod));
            Assert.That(expectedResultIsLoggedIn, Is.EqualTo(actualResultIsLoggedIn));
        }

        [Test, Order(7)]
        public void Test_07_LogIn_Success()
        {
            //Arrange
            ComputerSystem system = new ComputerSystem();
            system.CreateUserAccount("email@email.com", "password");
            system.CreateUserAccount("admin@admin.com", "password", true);

            //Casting. Probably not a smart thing to do and if so, be cast inside CreateUserAccount().
            User user = (User)system.Accounts[0];
            Administrator admin = (Administrator)system.Accounts[1];
            admin.EnableAccount(user, true);

            //Act
            bool expectedResultMethod = system.LogIn("email@email.com", "password");
            bool actualResultMethod = true;

            bool expectedResultIsLoggedIn = system.Accounts[0].IsLoggedIn;
            bool actualResultIsLoggedIn = true;

            //Assert
            Assert.That(expectedResultMethod, Is.EqualTo(actualResultMethod));
            Assert.That(expectedResultIsLoggedIn, Is.EqualTo(actualResultIsLoggedIn));
        }

    }
}
