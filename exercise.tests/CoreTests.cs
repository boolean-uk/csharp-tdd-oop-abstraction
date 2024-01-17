using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    TodoItem todoItem;

    [SetUp]
    public void SetUp()
    {
        todoItem = new TodoItem("title" ,"details" ,"DONE");
    }


    [Test]
    public void Test1()
    {
        Assert.That(todoItem.taskTitle, Is.EqualTo("title"));
        Assert.That(todoItem.taskDetails, Is.EqualTo("details"));
        Assert.That(todoItem.taskStatus, Is.EqualTo("DONE"));
    }

    [Test] 
    public void Test2() 
    {
        bool test = todoItem.SetStatusNotDone();

        Assert.That(test, Is.True);
        Assert.That(todoItem.taskStatus, Is.EqualTo("Not Done"));

        test = todoItem.SetStatusNotDone();

        Assert.That(test, Is.False);

        test = todoItem.SetStatusDone();

        Assert.That(test, Is.True);
        Assert.That(todoItem.taskStatus, Is.EqualTo("Done"));

        test = todoItem.SetStatusDone();
        Assert.That(test, Is.False);


    }



    [Test]
    public void Test3()
    {
        string expected = DateTime.Now.ToString();
        

        string test = todoItem.GetDateAndTime();
        
        Assert.That(test, Is.EqualTo(expected));
    }
}