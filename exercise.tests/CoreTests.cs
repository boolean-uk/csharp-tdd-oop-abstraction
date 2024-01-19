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
        Assert.That(item.Detail, Is.EqualTo(descr));
        Assert.That(item.Status, Is.EqualTo(status));

    }

    [TestCase(TodoItemStatus.NOT_DONE)]
    [TestCase(TodoItemStatus.DONE)]
    public void CanMarkItemAsDone(TodoItemStatus initalstatus)
    {
        TodoItem item = new TodoItem("", "", initalstatus);
        item.setDone();

        Assert.That(item.Status, Is.EqualTo(TodoItemStatus.DONE));
    }

    [TestCase(TodoItemStatus.NOT_DONE)]
    [TestCase(TodoItemStatus.DONE)]
    public void CanMarkItemAsNotDone(TodoItemStatus initalstatus)
    {
        TodoItem item = new TodoItem("", "", initalstatus);
        item.setNotDone();

        Assert.That(item.Status, Is.EqualTo(TodoItemStatus.NOT_DONE));
    }

    [Test]
    public void CanGetDateTime()
    {
        DateTime dt = _tditem.DateTime;
        string date = dt.ToString();

        DateTime now = DateTime.Now;
        string date2 = now.ToString();

        date = date.Substring(0, date.Length);
        date2 = date2.Substring(0, date2.Length);

        Assert.AreEqual(date, date2);


    }

}