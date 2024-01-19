using NUnit.Framework;

using exercise.main;

namespace exercise.tests;


[TestFixture]
public class CoreTests
{

    [TestCase("title", "description", TodoItemStatus.NOT_DONE)]
    [TestCase("title", "description", TodoItemStatus.DONE)]
    [TestCase("", "", TodoItemStatus.DONE)]
    public void CanCreateTodoItems(string title, string description, TodoItemStatus status)
    {
        TodoItem item = new TodoItem(title, description, status);
        Assert.That(item.Title, Is.EqualTo(title));
        Assert.That(item.Description, Is.EqualTo(description));
        Assert.That(item.Status, Is.EqualTo(status));
    }

    [TestCase(TodoItemStatus.NOT_DONE)]
    [TestCase(TodoItemStatus.DONE)]
    public void CanMarkItemAsDone(TodoItemStatus initialStatus)
    {
        TodoItem item = new TodoItem("", "", initialStatus);
        item.MarkAsDone();
        Assert.That(item.Status, Is.EqualTo(TodoItemStatus.DONE));
    }

    [TestCase(TodoItemStatus.DONE)]
    public void CannotMarkItemAsDoneIfAlreadyDone(TodoItemStatus initialStatus)
    {
        TodoItem item = new TodoItem("", "", initialStatus);
        Assert.That(() => item.MarkAsDone(), Throws.InvalidOperationException);
    }
}
