using exercise.main;
using Microsoft.VisualBasic;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        exercise.main.DateAndTime dateAndTime = new exercise.main.DateAndTime();

        Assert.That(dateAndTime.GetDate() == DateTime.Now.ToString("dd.MM.yyyy"));
        Assert.That(dateAndTime.GetTime() == DateTime.Now.ToString("t"));
    }

    [Test]
    public void StatusTest()
    {
        String detail = "Lorem ipsum is a placeholder text commonly used in publishing and graphic design to demonstrate the visual for of a document or a typeface without relying on meaningful content";
        
        TodoItem todoItem = new TodoItem("Lorem Ipsum", detail );

        Assert.That(todoItem.GetDetail() == detail);
        Assert.That(todoItem.GetTitle() == "Lorem Ipsum");

        Assert.That(todoItem.GetStatus() == "Incomplete");
        todoItem.SetStatus(StatusState.Complete);
        Assert.That(todoItem.GetStatus() == "Complete");

    }

}