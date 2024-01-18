using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void testGetTime()
    {
        // Arrange
        string testTitle = "Go home";
        string testDetail = "It's money";
        bool testStatus = false;
        TodoItem toDo = new TodoItem(testTitle,testDetail,testStatus);

        // Act
        DateTime result = toDo.Time;

        // Assert
        Assert.That(result, Is.EqualTo(new DateTime()));
        
    }
}