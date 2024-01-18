using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestConstructor()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Deriving");

        Assert.That(todoitem.Title, Is.EqualTo("Title"));
        Assert.That(todoitem.Detail, Is.EqualTo("Detail"));
        Assert.That(todoitem.Status, Is.EqualTo("Deriving"));
    }

    [Test]
    public void TestStatus()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Deriving");
        todoitem.StatusParked();
        Assert.That(todoitem.Status, Is.Not.EqualTo("Deriving"));
        Assert.That(todoitem.Status, Is.EqualTo("Parked"));

    }

    [Test]
    public void TestDateTime()
    {
        TodoItem todoitem = new TodoItem("Title", "Detail", "Deriving");

        DateTime dt = DateTime.Now;
        Assert.That(todoitem.Created.Hour, Is.EqualTo(dt.Hour));
    }

}