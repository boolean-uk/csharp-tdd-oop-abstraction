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
            UserAccount user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.SetPassword("thisisvoldemortspassword");
            Assert.IsTrue(user.IsThePasswordValid());
        }
        [Test]
        public void PaswordShouldBeLongerThenEightCharacters()
        {
            UserAccount user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.SetPassword("voldemo");
            Assert.IsFalse(user.IsThePasswordValid());
        }
        [Test]
        public void AccountUserEnable()
        {
            UserAccount user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.EnableAccount();
            Assert.IsTrue(user.IsTheAccountEnableOrDisable());
        }
        [Test]
        public void AccountUserDisable()
        {
            UserAccount user = new UserAccount("Avadakedavro@voldemort.Harry");
            user.DisableAccount();
            Assert.IsFalse(user.IsTheAccountEnableOrDisable());
        }
        [Test]
        public void AccountWithValidEmail()
        {
            UserAccount user = new UserAccount("Avadakedavro@voldemort.Harry");
            Assert.IsTrue(user.IsEmailValid());
        }
        [Test]
        public void AccountWithInvalidEmail()
        {
            UserAccount user = new UserAccount("Avadakedavrovoldemort.Harry");
            Assert.IsFalse(user.IsEmailValid());
        }
    }
}
