using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    TodoItem todoItem;

    [SetUp]
    public void SetUp()
    {
        todoItem = new TodoItem("title" ,"details" ,main.TaskStatus.Done);
    }


    [Test]
    public void Test1()
    {
        Assert.That(todoItem.taskTitle, Is.EqualTo("title"));
        Assert.That(todoItem.taskDetails, Is.EqualTo("details"));
        Assert.That(todoItem.taskStatus, Is.EqualTo(main.TaskStatus.Done));
    }

    [Test] 
    public void Test2() 
    {
        todoItem.SetStatusNotDone();

        Assert.That(todoItem.taskStatus, Is.EqualTo(main.TaskStatus.Not_done));

        todoItem.SetStatusNotDone();

        Assert.That(todoItem.taskStatus, Is.EqualTo(main.TaskStatus.Not_done));



        todoItem.SetStatusDone();

        Assert.That(todoItem.taskStatus, Is.EqualTo(main.TaskStatus.Done));

        todoItem.SetStatusDone();
        Assert.That(todoItem.taskStatus, Is.EqualTo(main.TaskStatus.Done));


    }



    [Test]
    public void Test3()
    {
        string expected = DateTime.Now.ToString();
        

        string test = todoItem.GetDateAndTime();
        
        Assert.That(test, Is.EqualTo(expected));
    }
}