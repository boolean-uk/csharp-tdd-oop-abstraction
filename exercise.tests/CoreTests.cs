using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        Assert.Pass();
    }


    [TestCase("TestTitle", "TestDetail", "TestStatus")]
    public void GetCreationTime(string title, string detail, string status)
    {
        TodoItem todoItem = new TodoItem(title, detail, status);
        DateTime testCreationTime =  DateTime.Now;

        Assert.That(todoItem.getCreated().ToString(), Is.EqualTo(testCreationTime.ToString()));
    }

    [TestCase("TestTitle", "TestDetail", "TestStatus")]
    public void getStatus(string title, string detail, string status)
    {
        TodoItem todoItem = new TodoItem(title, detail, status);
        Assert.That(todoItem.getStatus(), Is.EqualTo(status));
    }

    [TestCase("TestTitle", "TestDetail", "TestStatus","newStatus")]
    public void setStatus(string title, string detail, string status, string newStatus)
    {
        TodoItem todoItem = new TodoItem(title, detail, status);
        todoItem.setStatus(newStatus);
        Assert.That(todoItem.getStatus(),Is.EqualTo(newStatus));
        
    }
}