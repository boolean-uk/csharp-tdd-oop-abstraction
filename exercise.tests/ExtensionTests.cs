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
        public void CreateUser()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssen@outlook.com", "password123");
            //Verify
            Assert.IsNotNull(system.userList);
            Assert.That(system.userList[0].Email, Is.EqualTo("sebastian.hanssen@outlook.com"));
        }

        [Test]
        public void CreateUserEmailError()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssenoutlook.com", "password123");
            //Verify
            Assert.That(system.errorMessage, Is.EqualTo("Invalid E-mail."));
        }

        [Test]
        public void CreateUserPasswordError()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssen@outlook.com", "pass");
            //Verify
            Assert.That(system.errorMessage, Is.EqualTo("Invalid Password."));
        }

        [Test]
        public void SignInFail()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssen@outlook.com", "password123");
            system.signIn(system.userList[0]);
            //Verify
            Assert.IsNotNull(system.userList);
            Assert.That(system.userList[0].Email, Is.EqualTo("sebastian.hanssen@outlook.com"));
            Assert.That(system.errorMessage, Is.EqualTo("Account not enabled."));
            Assert.That(system.userList[0].SignedIn, Is.EqualTo(false));
            Assert.That(system.userList[0].Status, Is.EqualTo(false));
        }

        [Test]
        public void SignIn()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssen@outlook.com", "password123");
            system.toggleUser(system.userList[0]);
            system.signIn(system.userList[0]);
            //Verify
            Assert.IsNotNull(system.userList);
            Assert.That(system.userList[0].Email, Is.EqualTo("sebastian.hanssen@outlook.com"));
            Assert.That(system.userList[0].Status, Is.EqualTo(true));
        }

        [Test]
        public void SignInNoUserError()
        {
            //Set Up
            UserSystem system = new UserSystem();
            //Execute
            system.createUser("sebastian.hanssen@outlook.com", "password123");
            system.toggleUser("s.h@outlook.com");
            //Verify
            Assert.That(system.errorMessage, Is.EqualTo("There is no user with the e-mail s.h@outlook.com"));
        }
    }
}
