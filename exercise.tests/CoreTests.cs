namespace exercise.tests;
using exercise.main;

[TestFixture]
public class CoreTests
{
    TodoItem task;

    [SetUp]
    public void SetUp()
    {
        task = new TodoItem("Clean", "23/1 14:55", "Incomplete");
    }

    [Test]
    public void Test()
    {
        task.SeeDetails();
        Assert.Pass();
    }
}