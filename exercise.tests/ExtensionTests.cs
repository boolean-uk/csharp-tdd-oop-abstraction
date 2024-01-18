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
        private AccountSystem _system;
        [SetUp]
        public void SetUp()
        {
            _system = new AccountSystem();
        }
        [Test]
        [TestCase("e","b", "invalid email")]
        [TestCase("e@c","b", "invalid password")]
        [TestCase("e@c","12345678", "new user created")]
        public void CreatingAccountTests(string e, string p, string expected)
        {
            Assert.That(_system.createUser(e,p), Is.EqualTo(expected));
        }
    }
}
