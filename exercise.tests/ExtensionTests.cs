using exercise.main;
using NuGet.Frameworks;
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
        public void CreateAccountTest()
        {
            //arrange          
            UserManager uM = new UserManager();

            //act
            uM.CreateAccount("stian@email.com", "12345678");

            //assert
            Assert.IsTrue(uM.Users.Count() > 0);
        }

        [Test] 
        public void AccountDefaultStatusTest()
        {
            //arrange
            UserManager uM = new UserManager();

            //act
            uM.CreateAccount("stian@email.com", "12345678");

            //assert
            Assert.IsTrue(uM.Users[0].Status == "Disabled");
        }

        [Test]
        public void CanLoginTest()
        {
            //arrange
            UserManager uM = new UserManager();
            uM.CreateAccount("stian@email.com", "12345678");
            uM.Users.First().Status = "Enabled";

            //act
            bool result = uM.CanLogin("stian@email.com");

            //assert
            Assert.IsTrue(result == true);
        }
    }
}
