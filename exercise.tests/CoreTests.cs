using exercise.main;
using NUnit.Framework.Internal;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    private TodoItem todoItem;

    [SetUp]
    public void SetUp()
    {
        // create a new TodoItem from 
        todoItem = new TodoItem("Exercise", "Legday", "Incomplete");
    }

    // [TESTS] Getters
    [Test]
    public void TestGetTitle()
    {
        Assert.That(todoItem.GetTitle(), Is.EqualTo("Exercise"));
    }

    [Test]
    public void TestGetDetail()
    {
        Assert.That(todoItem.GetDetail(), Is.EqualTo("Legday"));
    }

    [Test]
    public void TestGetStatus()
    {
        Assert.That(todoItem.GetStatus, Is.EqualTo("Incomplete"));
    }

    [Test]
    public void TestGetDateTime()
    {
        Assert.That(todoItem.GetDateTimeCreatedTask, Is.EqualTo(todoItem.GetDateTimeCreatedTask()));
    }

    // [TEST] Setters

    [Test]
    public void TestSetTitle()
    {
        todoItem.SetTitle("Read documentation");
        Assert.That(todoItem.GetTitle(), Is.EqualTo("Read documentation"));
    }

    [Test]
    public void TestSetDetail()
    {
        todoItem.SetDetail("Clean Code");
        Assert.That(todoItem.GetDetail(), Is.EqualTo("Clean Code"));
    }

    [Test]
    public void TestSetStatus()
    {
        todoItem.SetStatus("Complete");
        Assert.That(todoItem.GetStatus(), Is.EqualTo("Complete"));
    }
}