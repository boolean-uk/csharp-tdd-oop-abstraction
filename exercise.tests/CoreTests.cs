namespace exercise.tests;
using exercise.main;

[TestFixture]
public class CoreTests
{
    TodoItem task;

    [SetUp]
    public void SetUp()
    {
        task = new TodoItem();
    }

    [TestCase("Clean", "Clean the whole house", false, 23, 12, true)]
    [TestCase("", "Clean the whole house", false, 23, 12, false)]
    [TestCase("Clean", "", false, 23, 12, false)]
    [TestCase("Clean", "Clean the whole house", true, 23, 12, true)]
    [TestCase("Clean", "Clean the whole house", false, 46, 12, false)]
    [TestCase("Clean", "Clean the whole house", false, 46, 122, false)]
    public void AddTasks(string title, string message, bool isDone, int date, int time, bool expected)
    {
        bool result = task.AddTask(title, message, date, time, isDone);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void TestTaskStatus()
    {
        task.SetTaskIncomplete();
        bool first = task.IsTaskDone();
        bool second = task.SetTaskComplete();
        Assert.That(first, Is.EqualTo(!second));
    }

    [TestCase("Clean the whole house", true)]
    [TestCase("", false)]
    public void AddDetails(string message, bool expected)
    {
        bool result = task.AddDetails(message);
        Assert.That(expected, Is.EqualTo(result));
    }
}