using exercise.main;

namespace exercise.tests;


[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        TodoItem todoItem = new TodoItem("Task1","Cleaning","Incomplete","July 07","13:00");
        string dateTest = todoItem.getDate();
        string timeTest = todoItem.getTime();


        Assert.IsTrue(dateTest == "July 07");
        Assert.IsTrue(timeTest == "13:00");

    }
}