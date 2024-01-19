using static System.Formats.Asn1.AsnWriter;
using NUnit.Framework;
using exercise.main;
using System.Net.NetworkInformation;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{

    private TodoItem _tditem;

    [SetUp]
    public void SetUp()
    {
        _tditem = new TodoItem("A", "B", TodoItemStatus.NOT_DONE);
    }

    [TestCase("title", "descr", TodoItemStatus.NOT_DONE)]
    [TestCase("title", "descr", TodoItemStatus.DONE)]
    [TestCase("", "", TodoItemStatus.NOT_DONE)]
    public void CanCreateTodoItems(string title, string descr, TodoItemStatus status)
    {
        TodoItem item = new TodoItem(title, descr, status);

        Assert.That(item.Title, Is.EqualTo(title));
        Assert.That(item.Description, Is.EqualTo(descr));
        Assert.That(item.Status, Is.EqualTo(status));

    }

    [TestCase(false, true)]
    [TestCase(true, true)]
    public void CanMarkItemAsDone(TodoItemStatus initalstatus, TodoItemStatus finalState)
    {
        TodoItem item = new TodoItem("", "", initalstatus);
        item.setDone();

        Assert.That(item.Status, Is.EqualTo(finalStatus));
    }

    [Test]
    public void CanGetDateTime()
    {
        DateTime dt = _tditem.getDateTime();
        
        string date = dt.Date.ToString();

        Assert.AreEqual(date, "17/01/2024 0.00.00");

    }

    [Test]
    public void StatusChanging()
    {
        string st1 = _tditem.getStatus();

        Assert.AreEqual(st1, "incomplete");

        _tditem.setTaskComplete();

        Assert.AreEqual(_tditem.getStatus(), "complete");


        _tditem.setTaskIncomplete();

        Assert.AreEqual(_tditem.getStatus(), "incomplete");

    }

}