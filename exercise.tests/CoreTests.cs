using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void DateTimeTest()
    {
        //arrange
        TodoItem todoItem = new TodoItem("Write to-do list", "Don't forget domain model", "Incomplete");
        //act
        DateTime taskTime = todoItem.getDateTimeCreated();
        //assert
        // tasks run instatnly with program, so date and time created should match with when program runs
        Assert.AreEqual(DateTime.Now.Date, taskTime.Date);
        Assert.AreEqual(DateTime.Now.Hour, taskTime.Hour);
    }
}