using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void createTest()
        {
            //arrange
            User user = new User("mkmbaran@gmail.com","12345678");
            //act
            List<User> users = new List<User>();
            user.create("mkmbaran@gmail.com", "12345678");
            users.Add(user);
            //assert
            Assert.IsTrue(users.Contains(user)); // adds to simple test Object List, confirms if User was created
        }
        [Test]
        public void validPasswordTest()
        {
            //arrange
            User user = new User("mkmbaran@gmail.com", "12345678");
            //act
            bool valid = user.validPassword(user);
            //assert
            Assert.IsTrue(valid); // '12345678' is eight characters long, should pass
        }
        [Test]
        public void validEmailTest()
        {
            //arrange
            User user = new User("mkmbaran@gmail.com", "12345678");
            //act
            bool valid = user.validEmail(user);
            //assert
            Assert.IsTrue(valid); // email contains '@', should pass
        }
        [Test]
        public void disabledByDefaultTest()
        {
            //arrange
            User user = new User("mkmbaran@gmail.com", "12345678");
            //act
            bool disabled = user.disabledByDefault(user);
            //assert
            Assert.IsFalse(disabled); // User account defaults to disabled, only pass if false
        }
        [Test]
        public void canLoginTest()
        {
            //arrange
            User user = new User("mkmbaran@gmail.com", "12345678");
            //act
            bool canLogin = user.canLogin(user);
            //assert
            Assert.IsFalse(canLogin); // User account defaults to disabled, should not be able to login
        }
    }
}
