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
        public void ValidUserTest()
        {
            User user = new User("Oneal", "oneal@gmail.com", "supersecurepassword");

            Assert.True(user.validEmail());
            Assert.True(user.validPassword());
        }
    }
}
