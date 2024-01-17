namespace exercise.tests;
using exercise.main;

[TestFixture]
public class CoreTests
{
    TodoItem task;

    [SetUp]
    public void SetUp()
    {
        task = new TodoItem("Clean", "Clean the house", "Incomplete", 23, 14);
    }

    [Test]
    public void Test()
    {
        task.PrintDataAndTime();
        Assert.Pass();
    }
}