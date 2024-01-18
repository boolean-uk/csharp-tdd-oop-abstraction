using exercise.main;
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
        public void testMakeAccount()
        {

            // Arrange
            string userName = "1234@hotmail.com";
            string passWord = "1234512314";
            
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
            Assert.IsTrue(status1 == false);  //Should returns true 
            Assert.IsTrue(status2 == true);  //Should returns false
        }

        [Test]
        public void testCheckUser()
        {

            // Arrange
            string userName1 = "1234@hotmail.com";
            string userName2 = "1234hotmail.com";
            //string passWord1 = "12345";
            string passWord2 = "123456789";

            Account accounts = new Account();

            // Act
            bool status1 = accounts.checkUser(userName1);
            bool status2 = accounts.checkUser(userName2);

            // Assert
            Assert.IsTrue(status1 == true);  //Should returns true 
            Assert.IsTrue(status2 == false);  //Should returns false
        }

        [Test]
        public void testEnableAccount()
        {

            // Arrange
            string userName1 = "1234@hotmail.com";
            string userName2 = "657@hotmail.com";
            string passWord1 = "12345112415";
            string passWord2 = "123456789";

            Account accounts = new Account();
            accounts.makeAccount(userName1, passWord1);
            accounts.makeAccount(userName2, passWord2);


            // Act
            Admin admin = new Admin();
            admin.enableAccount(userName1,true);

            bool status1 = accounts.getAccountStatus(userName1);
            bool status2 = accounts.getAccountStatus(userName2);

            // Assert
            Assert.IsTrue(status1 == true);  //Should returns true, since admin changed the status
            Assert.IsTrue(status2 == false);  //Should returns falsem, since false by default
        }
    }
}
