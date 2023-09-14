using NUnit.Framework;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void CreateATodoItem()
        {
            // arrange
            string title = "complete exercise";
            string detail = "write code for core and extension parts";
            string status = "doing";
            // act
            TodoItem todo = new TodoItem(title, detail, status);
            // assert
            Assert.IsTrue(todo != null);
            Assert.IsTrue(todo.Title == title);
            Assert.IsTrue(todo.Detail == detail);
        }

        [Test]
        public void ChangeStatusOfTodoItem()
        {
            // arrange
            string title = "complete exercise";
            string detail = "write code for core and extension parts";
            string status = "doing";
            TodoItem todo = new TodoItem(title, detail, status);
            // act
            todo.setStatus("done");
            // assert
            Assert.IsTrue(todo.getStatus() == "done");
        }
    }
}