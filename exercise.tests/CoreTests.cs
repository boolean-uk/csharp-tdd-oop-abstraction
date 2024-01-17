// CoreTests.cs
using exercise.main;

namespace exercise.tests
{
    public class CoreTests
    {
        private TodoItem _todoItem;

        [SetUp]
        public void Setup()
        {
            _todoItem = new TodoItem("Test Title" , "Test Detail" , "Test Status");
        }

        [Test]
        public void TestTodoItemCreation()
        {
            // Arrange
            var title = "Test Title";
            var detail = "Test Detail";
            var status = "Test Status";

            var todoItem = new TodoItem(title , detail , status);

            Assert.AreEqual(title , todoItem.Title);
            Assert.AreEqual(detail , todoItem.Detail);
            Assert.AreEqual(status , todoItem.Status);
            Assert.AreEqual(DateTime.Now.Date , todoItem.CreatedAt.Date);
        }

        [Test]
        public void TestTodoItemStatusChange()
        {
            var newStatus = "New Status";
            _todoItem.setStatus(newStatus);
            Assert.AreEqual(newStatus , _todoItem.getStatus());
        }
    }
}
