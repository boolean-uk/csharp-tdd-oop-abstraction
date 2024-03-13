using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using exercise.main;
using Account.main;


namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [SetUp]
        public void SetUp ()
        {
           
        }
        [Test]
        public void TestEnabled()
        {
            Assert.That(_enabled);
        }
    }
}
