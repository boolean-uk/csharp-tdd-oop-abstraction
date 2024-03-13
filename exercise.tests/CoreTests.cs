using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    private TodoItem todoItem;

    [SetUp]
    public void SetUp()
    {
        // create a new TodoItem from 
        todoItem = new TodoItem("Exercise", "Legday", "Incomplete");
    }

    [Test]
    public void TestGetTitle()
    {
        Assert.That(todoItem.GetTitle(), Is.EqualTo("Exercise"));
    }

    [Test] 
    public void TestGetDetail()
    {
        Assert.That(todoItem.GetDetail(), Is.EqualTo("Legday"));
    }

    [Test]
    public void TestGetStatus()
    {
        Assert.That(todoItem.GetStatus, Is.EqualTo("Incomplete"));
    }

    [Test]
    public void TestGetDateTime()
    {
        Assert.That(todoItem.GetDateTimeCreatedTask, Is.EqualTo(todoItem.GetDateTimeCreatedTask()));
    }
}