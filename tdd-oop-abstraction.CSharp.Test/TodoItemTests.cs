using NUnit.Framework;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class TodoItemTests
    {
        [Test]
        public void InitializingTodoItem()
        {
            int expectedId = 1;
            string expectedTitle = "Test Todo";
            string expectedDescription = "This is a test todo item.";

            TodoItem todoItem = new TodoItem(expectedId, expectedTitle, expectedDescription);

            Assert.AreEqual(expectedId, todoItem.Id);
            Assert.AreEqual(expectedTitle, todoItem.Title);
            Assert.AreEqual(expectedDescription, todoItem.Description);
            Assert.IsFalse(todoItem.IsCompleted); 
            Assert.IsTrue(todoItem.CreatedAt <= DateTime.Now); 
        }

        [Test]
        public void MarkingTodoItemAsCompleted()
        {
            TodoItem todoItem = new TodoItem(1, "Test Todo", "This is a test todo item.");

            todoItem.MarkTodoItemAsCompleted();

            Assert.IsTrue(todoItem.IsCompleted);
        }

        [Test]
        public void MarkingTodoItemAsIncomplete()
        {
            TodoItem todoItem = new TodoItem(1, "Test Todo", "This is a test todo item.");
            todoItem.MarkTodoItemAsCompleted(); 

            todoItem.MarkTodoItemAsIncomplete(); 

            Assert.IsFalse(todoItem.IsCompleted);
        }

        [Test]
        public void AddingMultipleTodoItems()
        {
            TodoItem todoItem1 = new TodoItem(1, "Todo 1", "Description 1");
            TodoItem todoItem2 = new TodoItem(2, "Todo 2", "Description 2");

            Assert.AreNotEqual(todoItem1.Id, todoItem2.Id);
        }

        [Test]
        public void TodoItemCreatedAt()
        {
            TodoItem todoItem = new TodoItem(1, "Test Todo", "This is a test todo item.");
            DateTime originalCreatedAt = todoItem.CreatedAt;

            Assert.AreEqual(originalCreatedAt, todoItem.CreatedAt);
        }
    }
}
