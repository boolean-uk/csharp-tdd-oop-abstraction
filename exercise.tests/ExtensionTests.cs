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
        [Test]
        public void testMakeAccount()
        {

            // Arrange
            string userName = "1234@hotmail.com";
            string passWord = "12345";
            
            Account accounts = new Account();

            // Act
            bool status = accounts.makeAccount(userName, passWord);

            // Assert
            Assert.IsTrue(status == true);  //True if the account was created.
        }

        [Test]
        public void testCheckPassword()
        {

            // Arrange
            string userName = "1234@hotmail.com";
            string passWord1 = "12345";
            string passWord2 = "123456789";

            Account accounts = new Account();

            // Act
            bool status1 = accounts.checkPassword(passWord1);
            bool status2 = accounts.checkPassword(passWord2);

            // Assert
            Assert.IsTrue(status1 == true);  //Should returns true 
            Assert.IsTrue(status2 == false);  //Should returns false
        }
    }
}
