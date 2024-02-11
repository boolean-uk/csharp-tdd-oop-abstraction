using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestConstructor()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Incomplete");

        Assert.That(todoitem.Title, Is.EqualTo("Title"));
        Assert.That(todoitem.Detail, Is.EqualTo("Detail"));
        Assert.That(todoitem.Status, Is.EqualTo("Incomplete"));
    }

    [Test]
    public void TestSetComplete()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Incomplete");

        todoitem.SetComplete();
        Assert.That(todoitem.Status, Is.EqualTo("Complete"));

        todoitem.SetComplete();
        Assert.That(todoitem.Status, Is.EqualTo("Complete"));
    }

    [Test]
    public void TestSetIncomplete()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Complete");

        todoitem.SetIncomplete();
        Assert.That(todoitem.Status, Is.EqualTo("Incomplete"));

        todoitem.SetIncomplete();
        Assert.That(todoitem.Status, Is.EqualTo("Incomplete"));
    }
    [Test]
    public void TestSetTitle()
    {
        TodoItem todoitem = new TodoItem("A title", "Detail", "Incomplete");

        todoitem.SetTitle();
        Assert.That(todoitem.Title, Is.EqualTo("A title"));

  
    }
    [Test]
    public void TestSetDetails()
    {
        TodoItem todoitem = new TodoItem("Title", "Some details", "Incomplete");

        todoitem.SetDetails();
        Assert.That(todoitem.Detail, Is.EqualTo("Some details"));

        todoitem.SetComplete();
        Assert.That(todoitem.Detail, Is.EqualTo("Some details"));
    }
    [Test]
    public void TestCreationTime()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Incomplete");

        Assert.That(todoitem.Created.Day, Is.EqualTo(DateTime.Now.Day));
        Assert.That(todoitem.Created.Hour, Is.EqualTo(DateTime.Now.Hour));
    }
}