using exercise.main;
using System.Reflection;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [TestCase("Test","This is a test task",true)]
    [TestCase("Test","This is a test task",false)]
    [TestCase("", "", true)] 
    public void CanCreateToDoItem(string title, string description, bool state) {
        TodoItem item = new TodoItem(title,description,state);

        Assert.That(item.Title, Is.EqualTo(title));
        Assert.That(item.Description, Is.EqualTo(description));
        Assert.That(item.IsDone, Is.EqualTo(state));
    }

    [TestCase(false)]
    [TestCase(true)]
    public void SetIsDoneTrue(bool s1) {
        TodoItem item = new TodoItem("","",s1);

        item.SetDone();

        Assert.That(item.IsDone, Is.EqualTo(true));
        Assert.That(item.IsDone, Is.EqualTo(true));
    }

    [TestCase(false)]
    [TestCase(true)]
    public void SetIsDonefasle(bool s1) {
        TodoItem item = new TodoItem("","",s1);

        item.SetNotDone();

        Assert.That(item.IsDone, Is.EqualTo(false));
        Assert.That(item.IsDone, Is.EqualTo(false));
    }

    [TestCase("new description")]
    public void ChangeDescription(string description) {
        TodoItem item = new TodoItem("","",false);

        item.Description = description;

        Assert.That(item.Description, Is.EqualTo(description));
    }

    [TestCase("new title")]
    public void ChangeTitle(string title) {
        TodoItem item = new TodoItem("","",false);

        item.Title = title;

        Assert.That(item.Title, Is.EqualTo(title));
    }

    [Test]
    public void GetDate() {
        TodoItem item = new TodoItem("Sample Title", "Sample Description", false);

        string currentDate = item.Date;

        Assert.IsNotNull(currentDate);
    }

    
}

