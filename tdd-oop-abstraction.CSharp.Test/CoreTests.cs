using NUnit.Framework;

using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void DescriptionsInDetails()
        {
            // arrange
            Details details = new Details();

            // act

            bool result = details.GetItem("Reach lvl 60 in WoW Classic Hardcore");

            // assert
            Assert.IsTrue(result == true);
        }
        [Test]
        public void AreYouDone()
        {
            // arrange
            Status status = new Status();
            // act

            bool result = status.TaskStatus.Where(x => x.Key == "C#").FirstOrDefault().Value;

            // assert

            Assert.IsTrue(result == true);
        }
        [Test]
        public void TestCreationDate()
        {
            TodoItem item = new TodoItem(
            "Mow the lawn",
            "Must go outside and get mower from shed and mow the lawn",
            "Finish today's exercises"
            );
            DateTime now = DateTime.Now;

            //I won't test the time - now will differ from TodoItem instantiation by milliseconds..
            Assert.AreEqual(item.Created.Day, now.Day);
            Assert.AreEqual(item.Created.Month, now.Month);
            Assert.AreEqual(item.Created.Year, now.Year);
            
          
        }
    }
}