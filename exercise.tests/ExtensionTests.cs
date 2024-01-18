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

        Client client;
        string message;

        [SetUp]
        public void Setup()
        {
            Client client = new Client();
            client.Create("email@email.com", "password", out message);
        }

        [Test]
        public void createUser()
        {
            client = new Client();
            string message;
            Assert.IsTrue(client.Create("email@email.com", "password", out message));
        }

        [Test]
        public void wrongEmail()
        {
            client = new Client();
            Assert.IsFalse(client.Create("email", "password", out message));
        }
        [Test]
        public void wrongPassword()
        {
            client = new Client();
            Assert.IsFalse(client.Create("email@email.com", "pasword", out message));
        }

        [Test]
        public void disabledUser()
        {
            Assert.IsFalse(client.Login("email@email.com", "password", out message));
        }

        [Test]
        public void login()
        {
            client.enable();
            Assert.IsTrue(client.Login("email@email.com", "password", out message));
        }
    }
}
