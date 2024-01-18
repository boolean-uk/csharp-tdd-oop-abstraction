using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void GetDateCreated_ShouldReturnCreationDate()
    {
        // Arrange
        var beforeCreation = DateTime.Now;
        var todoItem = new TodoItem("Test Title", "Test Detail", "Pending");

        // Act
        var creationDate = todoItem.GetDateCreated();
        var afterCreation = DateTime.Now;

        // Assert
        Assert.That(creationDate, Is.GreaterThanOrEqualTo(beforeCreation));
        Assert.That(creationDate, Is.LessThanOrEqualTo(afterCreation));
    }
}
