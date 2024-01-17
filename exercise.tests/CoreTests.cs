using exercise.main;
using NUnit.Framework;

namespace exercise.tests
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void Test()
        {
            Assert.Pass();
        }

        [Test]
        public void TodoItemProperties()
        {
            // Arrange
            string title = "Sample title";
            string detail = "Sample Detail";
            string status = "Complete";

            // Act
            TodoItem todoItem = new TodoItem(title, detail, status);

            // Assert
            Assert.AreEqual(title, todoItem.Title);
            Assert.AreEqual(detail, todoItem.Detail);
            Assert.AreEqual(status, todoItem.Status);
        }

        [Test]
        public void CreationDateTime()
        {
            // Arrange
            TodoItem todoItem = new TodoItem("Score", "Header", "Complete");

            // Act
            DateTime creationDateTime = todoItem.CreationDateTime;

            // Assert
            Assert.IsNotNull(creationDateTime);
            Assert.AreEqual(DateTime.Now.Date, creationDateTime.Date);
            Assert.AreEqual(DateTime.Now.Hour, creationDateTime.Hour);

            Console.WriteLine($"The task was created: {creationDateTime}");
        }
    }
}
