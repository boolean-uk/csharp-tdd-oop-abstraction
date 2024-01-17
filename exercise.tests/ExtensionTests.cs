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
        public void enableUserTest()
        {
            User user = new User("password123", "me@domain.com");
            Assert.IsFalse(user.canLogin());
        }
    }
}
