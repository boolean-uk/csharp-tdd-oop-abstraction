using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        private Admin _admin;

        [SetUp]
        public void SetUp()
        {
            _admin = new Admin();
        }

        [TestCase("asonroeinoit", "asonroeinoit@gmail.com", true, "account created!")]
        [TestCase("", "@sro", false, "invalid password!")]
        [TestCase("AAAAAAAAAA", "jetr", false, "invalid email!")]
        public void accountCreation(string password, string email, bool pass, string msg)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            bool result = _admin.approveAccount(password, email);

            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.That(msg, Is.EqualTo(outputLines[0]));

            Assert.AreEqual(pass, result);

        }

        [Test]
        public void NewDisabled()
        {
            _admin.approveAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");
            var us1 = _admin.getAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");

            Assert.NotNull(us1);
            Assert.IsFalse(us1.getStatus());

        }

        [Test]
        public void NonexistentAccountCannotBeFound()
        {
            var us1 = _admin.getAccount("AAAAAA", "AAAAA");
            Assert.IsNull(us1);
            
        }

        [Test]
        public void onlyAdminCanEnableAndDisableAccount()
        {
            _admin.approveAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");
            var us1 = _admin.getAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");
            Assert.NotNull(us1);

            us1.setAccountEnabled(us1);
            Assert.IsFalse(us1.getStatus());

            _admin.setAccountEnabled(us1);
            Assert.IsTrue(us1.getStatus());

            _admin.setAccountInabled(us1);
            Assert.IsFalse(us1.getStatus());
        }

        [Test]
        public void CanUserLogin()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _admin.approveAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");
            var us1 = _admin.getAccount("AAAAAAAAAAA", "AAAAAAAAAAAA@");
            Assert.NotNull(us1);

            bool login = us1.canLogin();

            Assert.IsFalse(login);

            _admin.setAccountEnabled(us1);

            Assert.IsTrue(us1.canLogin());

            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.That("Your account is not active - you can not login yet!", Is.EqualTo(outputLines[1]));
            Assert.That("Your account is active - you can login!", Is.EqualTo(outputLines[2]));
           

        }
    }
}
