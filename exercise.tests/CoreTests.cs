using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void GetDateTimeTest()
    {
        //arrange
        TodoItem todoItem = new TodoItem("Clean kitchen", "Clean stove and pan in kitchen", "Incomplete");

        //act
        DateTime result = todoItem.GetDateTime();

        //assert
        Assert.AreEqual(todoItem.GetDateTime(), result);
    }

}