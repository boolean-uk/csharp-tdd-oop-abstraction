using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void DateTest()
    {
        TodoItem test = new TodoItem("Test", "Testing if the date is created and accesed");
        
        Assert.That(test.createTime().Minute, Is.EqualTo(DateTime.Now.Minute));
    }
}