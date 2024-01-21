using exercise.main;
using System.ComponentModel;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    private TodoItem myTodoItem;

    //Test creation of items
    [TestCase("title1", "description1", TodoItemStatus.NOT_DONE)]
    [TestCase("title1", "description1", TodoItemStatus.DONE)]
    [TestCase("", "", TodoItemStatus.DONE)]

    public void CreateTodoItems(string title, string description, TodoItemStatus status)
    {
        TodoItem item = new TodoItem(title, description, status);

        Assert.That(item.getTitle, Is.EqualTo(title));
        Assert.That(item.getDescription, Is.EqualTo(description));
        Assert.That(item.status, Is.EqualTo(status));
    }

    //test the status, to set as done
    [TestCase(TodoItemStatus.DONE)]
    [TestCase(TodoItemStatus.NOT_DONE)]
    public void CanChangeStatusDone(TodoItemStatus originalStatus) 
    {
        TodoItem item = new TodoItem("", "", originalStatus);

        item.setDone();

        Assert.That(item.status, Is.EqualTo(TodoItemStatus.DONE));
    }

    //test change status to not_done
    [TestCase(TodoItemStatus.DONE)]
    [TestCase(TodoItemStatus.NOT_DONE)]
    public void CanChangeStatusNotDone(TodoItemStatus originalStatus)
    {
        TodoItem item = new TodoItem("", "", originalStatus);

        item.setNotDone();

        Assert.That(item.status, Is.EqualTo(TodoItemStatus.NOT_DONE));
    }

    //test to set title
    [Test]
    public void SetTitleTest() 
    {
        TodoItem item = new TodoItem("title", "description", TodoItemStatus.NOT_DONE);
        
        Assert.AreEqual("title", item.getTitle());
        
        item.setTitle("title1");

        Assert.AreEqual("title1", item.getTitle());

        Assert.IsFalse(item.setTitle("title1"));

        Assert.IsFalse(item.setTitle(""));
    }

    //test to set description
    [Test]
    public void SetDescriptionTest()
    {
        TodoItem item = new TodoItem("title", "description", TodoItemStatus.NOT_DONE);

        Assert.AreEqual("description", item.getDescription());

        item.setDescription("description1");

        Assert.AreEqual("description1", item.getDescription());

        Assert.IsFalse(item.setDescription("description1"));

        Assert.IsFalse(item.setDescription(""));
    }

}