using exercise.main;

namespace exercise.tests;


[TestFixture]
public class CoreTests
{
    [Test]
    public void FetchDataTest()
    {
        TodoItem todoItem = new TodoItem("Task1","Cleaning",Status.Done,"July 07","13:00");


        Assert.IsTrue(todoItem.getDate() == "July 07");
        Assert.IsTrue(todoItem.getTime() == "13:00");
        Assert.IsTrue(todoItem.getTitle() == "Task1");
        Assert.IsTrue(todoItem.getDetail() == "Cleaning");

    }

    [Test]
    public void StatusTest()
    {
        TodoItem todoItem = new TodoItem("Task1", "Cleaning", Status.Done, "July 07", "13:00");
        todoItem.isCompleted();

        Assert.IsTrue(todoItem.getStatus() == Status.Done);
        
        todoItem.isNotCompleted();

        Assert.IsTrue(todoItem.getStatus() == Status.Not_Done);

        todoItem.isNotCompleted();

        Assert.IsTrue(todoItem.getStatus() == Status.Not_Done);
    }


}