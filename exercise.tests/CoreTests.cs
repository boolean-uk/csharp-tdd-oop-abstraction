using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    TodoItem todo = new("a", "b", "c");
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void CreationTimeTest()
    {
        Assert.That(todo.getCreation().Date, Is.EqualTo(DateTime.Now.Date));
    }
}