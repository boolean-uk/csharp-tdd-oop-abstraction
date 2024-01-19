using exercise.main;
namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    string title;
    string details;

    [SetUp]
    public void SetUp()
    {
        title = "Get this test to pass";
        details = "Push to GitHub once done.";
    }

    [Test]
    public void TodoItemHasAllValuesTest()
    {
        TodoItem todo = new TodoItem(title, details);
        Assert.That(todo.Title == title);
        Assert.That(todo.Details == details);
        Assert.That(todo.IsDone == false);
        Assert.That((DateTime.Now - todo.CreationTime).TotalSeconds < 5);
    }

    [Test]
    public void TodoItemStatusTest()
    {
        TodoItem todo = new TodoItem(title, details);
        todo.MarkDone();
        Assert.That(todo.IsDone == true && todo.Status().Contains("Done"));
        todo.MarkUndone();
        Assert.That(todo.IsDone == false && todo.Status().Contains("Pending"));
    }

}