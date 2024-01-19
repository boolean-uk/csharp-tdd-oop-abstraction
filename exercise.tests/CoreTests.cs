
using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestChangeStatus()
    {
        TodoItem todoItem = new TodoItem("Task 1", "Running", true);
        Assert.That(true, Is.EqualTo(todoItem.IsDone));
    }

    [Test]
    public void TestDateTime()
    {
        TodoItem todoItem = new TodoItem("Task 1", "Running", false);
        DateTime created = todoItem.Date;
        DateTime now = DateTime.Now;

        Assert.That(now.Date, Is.EqualTo(created.Date));
    }
}