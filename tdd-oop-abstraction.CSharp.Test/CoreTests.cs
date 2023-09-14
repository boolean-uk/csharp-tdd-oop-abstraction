using NUnit.Framework;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void TryGetStatus()
        {
            TodoItem todo = new TodoItem("Service my car","Change oil and Brakedisks","12:00 16 August 2023");

            todo.getStatus();

            Assert.IsTrue(todo.getStatus() == "12:00 16 August 2023");
        }
    }
}