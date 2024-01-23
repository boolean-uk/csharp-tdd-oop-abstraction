
using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [TestCase ("Task 1", "Running", TodoStatus.NOT_DONE)]
    [TestCase ("", "", TodoStatus.NOT_DONE)]
    public void CanCreateToDoItem(string title, string description, TodoStatus status)
    {
        TodoItem todoItem = new TodoItem(title, description, status);
        Assert.That(todoItem.Title, Is.EqualTo(title));
        Assert.That(todoItem.Detail, Is.EqualTo(description));
        Assert.That(todoItem.Status, Is.EqualTo(status));
    }

    [TestCase ("small")]
    [TestCase ("")]
    [TestCase ("CAPITAL")]
    [TestCase ("Special@¤6/52")]
    public void CanUpdateTitle(string update) {
        TodoItem todoItem = new TodoItem("Title", "description", TodoStatus.NOT_DONE);
        todoItem.UpdateTitle(update);
        Assert.That(todoItem.Title, Is.EqualTo(update));
    }

    [TestCase ("small   ")]
    [TestCase ("")]
    [TestCase ("CAPITAL")]
    [TestCase ("Special@¤6/52")]
    public void CanUpdateDescription(string update) {
        TodoItem todoItem = new TodoItem("Title", "description", TodoStatus.NOT_DONE);
        todoItem.UpdateDescription(update);
        Assert.That(todoItem.Detail, Is.EqualTo(update));
    }
}