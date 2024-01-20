using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [TestCase("test", "test")]
    [TestCase("", "")]
    public void TodoItemCreation(string title, string detail)
    {
        TodoItem todo = new TodoItem(title, detail);
        Assert.That(todo.getStatus, Is.EqualTo("Not done"));
        DateTime dateTime = DateTime.Now;
        Assert.That(todo.getCreated().ToString(), Is.EqualTo(dateTime.ToString()));
    }

    [TestCase("TestTitle", "TestDetail")]
    public void getStatus(string title, string detail)
    {
        TodoItem todoItem = new TodoItem(title, detail);
        Assert.That(todoItem.getStatus(), Is.EqualTo("Not done"));
    }

    [TestCase("TestTitle", "TestDetail")]
    public void setStatusDone(string title, string detail)
    {
        TodoItem todoItem = new TodoItem(title, detail);
        Assert.That(todoItem.getStatus(), Is.EqualTo("Not done"));
        todoItem.setStatusDone();
        Assert.That(todoItem.getStatus(), Is.EqualTo("Done"));
        todoItem.setStatusDone();
        Assert.That(todoItem.getStatus(), Is.EqualTo("Done"));
    }

    [TestCase("TestTitle", "TestDetail")]
    public void setStatusNotDone(string title, string detail)
    {
        TodoItem todoItem = new TodoItem(title, detail);
        Assert.That(todoItem.getStatus(), Is.EqualTo("Not done"));
        todoItem.setStatusNotDone();
        Assert.That(todoItem.getStatus(), Is.EqualTo("Not done"));
    }

    [TestCase("TestTitle", "TestDetail")]
    public void GetCreationTime(string title, string detail)
    {
        TodoItem todoItem = new TodoItem(title, detail);
        DateTime testCreationTime = DateTime.Now;
        Assert.That(todoItem.getCreated().ToString(), Is.EqualTo(testCreationTime.ToString()));
    }


}