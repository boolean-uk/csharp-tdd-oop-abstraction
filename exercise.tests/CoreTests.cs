using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TodoItem_StatusCanBeChanged()
    {
        // Arrange
        TodoItem todoItem = new TodoItem("Complete Coding Assignment", "Finish the programming tasks", "InProgress");

        //Act
        todoItem.setStatus("Completed");

        //Assert
        Assert.AreEqual("Completed", todoItem.getStatus(), "Status should be changed to 'Completed'.");


    }

    [Test]
    public void CreationDateTimeShouldBeSetRight()
    {
        // Arrange
        TodoItem todoItem = new TodoItem("Complete Coding Assignment", "Finish the programming tasks", "InProgress");

        //Act
        DateTime creationDateTime = todoItem.getCreationDateTime();

        //Assert
        Assert.AreEqual(DateTime.Now.Date, creationDateTime.Date, "Creation date should match the current date.");
        Assert.AreEqual(DateTime.Now.Hour, creationDateTime.Hour, "Creation hour should match the current hour.");
        Assert.AreEqual(DateTime.Now.Minute, creationDateTime.Minute, "Creation minute should match the current minute.");    }

}