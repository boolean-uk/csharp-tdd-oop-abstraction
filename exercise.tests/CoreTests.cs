using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestTodoItemTime()
    {
        // Arrange
        TodoItem item = new TodoItem("Title", "Details", "Not complete");

        // Act
        DateTime createdTime = item.getCreationTime();
        DateTime currentTime = DateTime.Now;

        // Assert
        Assert.That(createdTime.Year, Is.EqualTo(currentTime.Year));
        Assert.That(createdTime.Month, Is.EqualTo(currentTime.Month));
        Assert.That(createdTime.Day, Is.EqualTo(currentTime.Day));

        Assert.That(createdTime.Hour, Is.EqualTo(currentTime.Hour).Or.EqualTo(currentTime.Hour + 1));
        Assert.That(createdTime.Minute, Is.EqualTo(currentTime.Minute).Or.EqualTo(currentTime.Minute + 1));
        Assert.That(createdTime.Second, Is.EqualTo(currentTime.Second).Within(10));
    }
}