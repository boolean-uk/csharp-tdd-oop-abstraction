using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void getCreationTimeTest()
    {
        TodoItem todo = new TodoItem("Write tests for TodoItem.", "TodoItem needs some tests, write them.");
        var result = todo.getCreationTime();
        DateTime dateTime = DateTime.Now;

        Assert.That(result, Is.EqualTo(dateTime));
    }

    [Test]
    public void completeTest()
    {
        TodoItem todo = new TodoItem("Write tests for TodoItem.", "TodoItem needs some tests, write them.");
        todo.Complete();
        TodoItem todo1 = new TodoItem("Write tests for TodoItem.", "TodoItem needs some tests, write them.");

        Assert.That(todo.isComplete(), Is.EqualTo(true));
        Assert.That(todo1.isComplete(), Is.EqualTo(false));
    }

    [Test]
    public void getTaskTest()
    {
        string title = "Write tests for TodoItem.";
        string desc = "TodoItem needs some tests, write them.";
        TodoItem todo = new TodoItem(title, desc);

        Assert.That(todo.getTask(), Is.EqualTo($"{title} {desc}"));
    }
}