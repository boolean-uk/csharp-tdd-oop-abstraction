using tdd_oop_abstraction.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Net;

namespace tdd_oop_abstraction.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void ExtensionTest1() // Create new account
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            allUsers.New("test@email.com", "password1");

            //assert
            Assert.IsTrue(allUsers.Users.Count > 0);
        }


        [Test]
        public void ExtensionTest2() // "invalid password" message if user provides password < 8 characters 
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            string response = allUsers.New("test@email.com", "1234");

            //assert
            Assert.IsTrue(response.Contains("Invalid password"));

        }

        [Test]
        public void ExtensionTest3() // "invalid email" message if user provides email without "@" symbol
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            string response = allUsers.New("test-email.com", "password");

            //assert
            Assert.IsTrue(response.Contains("Invalid email"));
        }

        [Test]
        public void ExtensionTest4() // I want new accounts to be disabled by default until I manually set them as enabled.
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            allUsers.New("test@email.com", "password");

            //assert
            Assert.IsFalse(allUsers.Users[0].VisibleStatus);
        }

        [Test]
        public void ExtensionTest5() // A way to set the status manually.
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            allUsers.New("test@email.com", "password");
            allUsers.Users[0].setStatus(true);

            //assert
            Assert.IsTrue(allUsers.Users[0].VisibleStatus);
        }

        [Test]
        public void ExtensionTest6() // I want users to know if they are able to log in or not based on whether their account is enabled or disabled.
        {
            //arrange
            UserList allUsers = new UserList();

            //act
            allUsers.New("test@email.com", "password");

            allUsers.Users[0].setStatus(true);

            string response = allUsers.CanThisUserLogIn("test@email.com");

            //assert
            Assert.IsTrue(response.Equals("User can log in"));
        }
    }
}
