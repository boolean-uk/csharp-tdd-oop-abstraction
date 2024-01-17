using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void CanChangeStatusOfTaskTest()
    {
        TodoItem item = new("First Task", "Some task detail", Status.Unfinished);

        item.Status = Status.Finished;
        Assert.That(item.Status, Is.EqualTo(Status.Finished));
    }

    [Test]
    public void ViewDateTimeForTaskCreatedTest()
    {
        TodoItem item = new("Second Task", "Some other task detail", Status.Unfinished);

        Assert.That(item.DateCreated, Is.GreaterThanOrEqualTo(new DateTime()));
    }
}