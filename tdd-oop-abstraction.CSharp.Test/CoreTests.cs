using NUnit.Framework;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [TestFixture]
        public class TestsCore
        {
            [Test]
            public void DateAndTimeNeedToBeSet()
            {
                string title = "this is a title";
                string detail = "this is a detail";
                string status = "this is a status";
                TodoItem todoItem = new TodoItem(title, detail, status);
                Assert.That(todoItem.CreatedDateTime, Is.Not.EqualTo(default(DateTime)));
            }
            [Test]
            public void DateTimeShouldNotChange()
            {
                TodoItem todoItem = new TodoItem("a new title", "a new detail", "a new status");
                DateTime initialCreationTime = todoItem.CreatedDateTime;
                Assert.AreEqual(initialCreationTime, todoItem.CreatedDateTime);
            }
        }
    }
}
