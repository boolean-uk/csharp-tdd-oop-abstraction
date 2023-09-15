using tdd_oop_abstraction.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_oop_abstraction.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void IsPasswordSet()
        {
            var user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.SetPassword("thisisvoldemortspassword");
            Assert.IsTrue(user.IsThePasswordValid());
        }
        [Test]
        public void PaswordShouldBeLongerThenEightCharacters()
        {
            var user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.SetPassword("voldemo");
            Assert.IsFalse(user.IsThePasswordValid());
        }
        [Test]
        public void AccountUserEnable()
        {
            var user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.EnableAccount();
            Assert.IsTrue(user.IsTheAccountEnableOrDisable());
        }
        [Test]
        public void AccountUserDisable()
        {
            var user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.DisableAccount();
            Assert.IsFalse(user.IsTheAccountEnableOrDisable());
        }
        [Test]
        public void AccountWithValidEmail()
        {
            var user = new UserAccount("Avadakedavro@voldemort.Harry");
            Assert.IsTrue(user.IsEmailValid());
        }
        [Test]
        public void AccountWithInvalidEmail()
        {
            var user = new UserAccount("Avadakedavrovoldemort.Harry");
            Assert.IsFalse(user.IsEmailValid());
        }
    }
}
