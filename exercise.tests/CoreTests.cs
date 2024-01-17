using NUnit.Framework;
using exercise.main;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
namespace exercise.tests;


[TestFixture]
public class CoreTests
{
    private TodoItem todoItem;
    private string title;
    private string detail;
    private string status;

    [SetUp]
    public void SetUp()
    {
        // Common setup code that runs before each test
        string title = "Test Title";
        string detail = "Test Detail";
        string status = "Test Status";
        DateTime creationTime = new DateTime(2023, 1, 17, 12, 0, 0);

        todoItem = new TodoItem(title, detail, status, creationTime);
    }


    [Test]
    public void SetUpTest()
    {
        //checking that todoItem is setup as desired
        Assert.That(todoItem.getTitle(), Is.EqualTo("Test Title"));
        Assert.That(todoItem.getDetail(), Is.EqualTo("Test Detail"));
        Assert.That(todoItem.getStatus(), Is.EqualTo("Test Status"));

        string timenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        // Assert that the DateAndTime is set to the time of creation and not equal to now
        Assert.That(todoItem.DateAndTime, Is.Not.EqualTo(timenow).Within(3).Seconds);
    }



    [Test]
    public void DateAndTimeTest()
    {
        // Act 
        string expectedDateTime = todoItem.DateAndTime;

        // Assert
        Assert.IsNotNull(expectedDateTime);
        Assert.AreEqual(expectedDateTime, todoItem.DateAndTime);
    }


    [Test]
    public void changeStatusTest()
    {
        //checking if status is changed to complete
        todoItem.toComplete();

        Assert.That(todoItem.isComplete(), Is.True);
        Assert.That(todoItem.getStatus, Is.EqualTo("complete"));

        //check that nothing fails when changing to complete one moer time
        todoItem.toComplete();

        Assert.That(todoItem.isComplete(), Is.True);

        //checking that staus is changed to incomplete
        todoItem.toIncomplete();

        Assert.That(todoItem.isComplete(), Is.False);
        Assert.That(todoItem.getStatus, Is.EqualTo("incomplete"));
    }
}