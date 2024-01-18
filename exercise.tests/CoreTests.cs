using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Constructor_SetsPropertiesCorrectly()
    {
        TodoItem todo = new TodoItem("Title", "Detail", "Pending");

        Assert.That(todo.Title, Is.EqualTo("Title"));
        Assert.That(todo.Detail, Is.EqualTo("Detail"));
        Assert.That(todo.Status, Is.EqualTo("Pending"));

        // Check the creation date and time within a reasonable range
        Assert.That(todo.Creationdatetime, Is.EqualTo(DateTime.Now).Within(TimeSpan.FromSeconds(1)));
    }
}