using exercise.main;
using NUnit.Framework;

namespace exercise.tests;



[TestFixture]
public class CoreTests

{
    private TodoItem todoItem;

    [SetUp]
    public void Setup()
    {
        todoItem = new TodoItem("Code", "Finish abstraction exercise");
    }

    [Test]
    public void TestGetTitle()
    {
        Assert.That(todoItem.Title, Is.EqualTo("Code"));
    }

    [Test]
    public void TestSetTitle()
    {
        todoItem.Title = "Walk outside";
        Assert.That(todoItem.Title, Is.EqualTo("Walk outside"));
    }

    [Test]
    public void TestGetDetail()
    {
        Assert.That(todoItem.Detail, Is.EqualTo("Finish abstraction exercise"));
    }

    [Test]
    public void TestSetDetail()
    {
        todoItem.Detail = "5K";
        Assert.That(todoItem.Detail, Is.EqualTo("5K"));
    }

    [Test]
    public void TestGetStatus()
    {
        Assert.That(todoItem.Status, Is.EqualTo(false));
    }

    [Test]
    public void TestSetStatus()
    {
        todoItem.SetComplete();
        Assert.That(todoItem.Status, Is.True);
        todoItem.SetIncomplete();
        Assert.That(todoItem.Status, Is.False);
    }
}