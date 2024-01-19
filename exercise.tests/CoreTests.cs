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
            var title = "Test Title";
            var detail = "Test Detail";
            var status = "Test Status";

            var todoItem = new TodoItem(title , detail , status);

            Assert.AreEqual(title , todoItem.Title);
            Assert.AreEqual(detail , todoItem.Detail);
            Assert.AreEqual(status == "complete" , todoItem.IsComplete);
            Assert.AreEqual(DateTime.Now.Date , todoItem.Time.Date);
        }

        [Test]
        public void TestTodoItemStatusChange()
        {
            _todoItem.SetComplete();
            Assert.IsTrue(_todoItem.IsComplete);
            _todoItem.SetIncomplete();
            Assert.IsFalse(_todoItem.IsComplete);
        }

        [Test]
        public void TestTodoItemCreationTime()
        {
            Assert.AreEqual(DateTime.Now.Date , _todoItem.Time.Date);
        }

    }
}
