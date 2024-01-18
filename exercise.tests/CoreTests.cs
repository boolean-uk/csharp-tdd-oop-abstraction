using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void ShouldSetStatusOfTodoItemToComplete()
    {
        TodoItem todoItem = new TodoItem("Wash the cat", "With soap");
        todoItem.setComplete();
        Assert.That(todoItem.getStatus() == "Complete");
    }
    [Test]
    public void ShouldHaveStatusIncomplete()
    {
        TodoItem todoItem = new TodoItem("Wash the cat", "With soap");
        Assert.That(todoItem.getStatus() == "Incomplete");
    }
    [Test]
    public void ShouldGetDateItemIsCreated()
    {
        TodoItem todoItem = new TodoItem("Wash the cat", "With soap");
        DateTime date = DateTime.Now;
        Assert.That(date.ToString(), Is.EqualTo(todoItem.getDateCreated()));
    }
}