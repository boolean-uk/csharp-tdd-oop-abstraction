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
        todoItem = new TodoItem("Code", "Finish abstraction exercise", "Incomplete");
    }

    [Test]
    public void TestGetTitle()
    {
        Assert.That(todoItem.getTitle(), Is.EqualTo("Code"));
    }

    [Test]
    public void TestSetTitle()
    {
        todoItem.setTitle("Walk outside");
        Assert.That(todoItem.getTitle(), Is.EqualTo("Walk outside"));
    }

    [Test]
    public void TestGetDetail()
    {
        Assert.That(todoItem.getDetail(), Is.EqualTo("Finish abstraction exercise"));
    }

    [Test]
    public void TestSetDetail()
    {
        todoItem.setDetail("5K");
        Assert.That(todoItem.getDetail(), Is.EqualTo("5K"));
    }

    [Test]
    public void TestGetStatus()
    {
        Assert.That(todoItem.getStatus(), Is.EqualTo("Incomplete"));
    }

    [Test]
    public void TestSetStatus()
    {
        todoItem.setStatus("Complete");
        Assert.That(todoItem.getStatus(), Is.EqualTo("Complete"));
    }
}