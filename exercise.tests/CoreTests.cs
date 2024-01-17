
using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestChangeStatus()
    {
        TodoItem todoItem = new TodoItem("Task 1", "Running", "Incomplete");
        todoItem.SetStatus(true);
        StringAssert.Contains("Complete", todoItem.Status);
    }

    [Test]
    public void TestDateTime()
    {
        TodoItem todoItem = new TodoItem("Task 1", "Running", "Incomplete");
        DateTime created = todoItem.Date;
        DateTime now = DateTime.Now;

        Assert.That(now.Date, Is.EqualTo(created.Date));
    }
}