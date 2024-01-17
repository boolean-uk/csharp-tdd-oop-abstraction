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
    [Test]
    public void TitleTest()
    {
        TodoItem todo = new TodoItem("Playing Football", "Tired", false);

        Assert.IsTrue(todo.Title == "Playing Football");

    }
    [Test]
    public void CreationDate()
    {
        TodoItem todo = new TodoItem("Playing Football", "Tired", false);
        DateTime date = DateTime.Now;
        Assert.IsTrue(date.Year == todo.Created.Year);
        Assert.IsTrue(date.Month == todo.Created.Month);
        Assert.IsTrue(date.Day == todo.Created.Day);
    }

    [Test]
    public void DetailTest()
    {
        TodoItem todo = new TodoItem("Playing Football", "Tired", false);
        Assert.IsTrue(todo.Detail == "Tired");
    }

    [Test]
    public void StatusTest()
    {
        TodoItem todo = new TodoItem("Playing Football", "Tired", false);
        Assert.IsTrue(todo.Status == false);




    }
}