using exercise.main.Core;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void CanChangeStatusOfTaskTest()
    {
        TodoItem item = new("First Task", "Some task detail");
        Assert.That(item.Finished, Is.False);

        item.Finished = true;
        Assert.That(item.Finished, Is.True);
    }

    [Test]
    public void ViewDateTimeForTaskCreatedTest()
    {
        TodoItem item = new("Second Task", "Some other task detail");

        Assert.That(item.DateCreated, Is.GreaterThanOrEqualTo(new DateTime()));
    }
}