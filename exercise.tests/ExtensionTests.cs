using exercise.main;

namespace exercise.tests;

[TestFixture]
public class ExtensionTests
{
    [TestCase("123@123", "12345678", true)]
    [TestCase("123@123", "1234567", false)]
    [TestCase("123123", "12345678", false)]
    [TestCase("123123", "1234567", false)]
    public void createUserTest(string email, string password, bool isValid)
    {
        Extension extension = new Extension();
        bool result = extension.createUser(email, password);

        Assert.That(result, Is.EqualTo(isValid));
    }

    [Test]
    public void canLoginTest()
    {
        User user = new User("123@123", "12345678");
        bool result = user.canLogin();
        user.activate();
        bool result1 = user.canLogin();

        Assert.That(result, Is.EqualTo(false));
        Assert.That(result1, Is.EqualTo(true));
    }
}
