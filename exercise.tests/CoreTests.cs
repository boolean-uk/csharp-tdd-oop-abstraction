using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    private TodoItem myTodoItem;

    [SetUp]
    public void Setup() 
    {
        //create one instance of TodoItem
        Console.WriteLine("Test started");
        myTodoItem = new TodoItem("Title", "Details", "Status");
        Console.WriteLine("Setup Complete");

    }

    [Test]
    public void Test()
    {
        //Check if status and DateTime is correct
        string currentTime = DateTime.Now.ToString();
        string currentStatus = "Status";

        Assert.AreEqual(myTodoItem.getStatus(), currentStatus);
        Assert.AreEqual(myTodoItem.getDateTime(), currentTime);
    }
}