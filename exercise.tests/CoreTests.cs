using exercise.main;
using System.Reflection;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    private TodoItem todoItem;
    [SetUp]
    public void SetUp()
    {
        string title = "Test Task";
        string detail = "This is a test task";
        string status = "Pending";
        todoItem = new TodoItem(title, detail, status);
    }
    

    [Test]
    public void TodoItem_GetStatus_ShouldReturnStatus()
    {

        string retrievedStatus = todoItem.getStatus();

        // Assert
        Assert.AreEqual("Pending", retrievedStatus);
    }

    [Test]
    public void TodoItem_Creation_ShouldSetProperties()
    {
        string title = "Test Task";
        string detail = "This is a test task";
        string status = "Pending";

        // Assert
        Assert.AreEqual(title, todoItem.getTitle());
        Assert.AreEqual(detail, todoItem.getDetail());
        Assert.AreEqual(status, todoItem.getStatus());
    }

    [Test]
    public void TodoItem_Creation_ShouldSetDate()
    {
        // Assert
        Assert.That(todoItem.getDate(), Is.EqualTo(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).Within(TimeSpan.FromSeconds(1)));
    }

    [Test]
    public void TodoItem_SetStatus_ShouldUpdateStatus()
    {
        // Arrange
        string title = "Test Task";
        string detail = "This is a test task";
        string status = "Pending";

        // Act
        string newStatus = "Completed";
        todoItem.setStatus(newStatus);

        // Assert
        Assert.AreEqual(newStatus, todoItem.getStatus());
    }
}

