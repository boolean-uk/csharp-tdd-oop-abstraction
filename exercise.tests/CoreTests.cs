using exercise.main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;


namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    TodoItem toDoItem;
    [SetUp]
    public void Setup()
    {
        toDoItem = new TodoItem("title", "detail", "status");

    }

    [Test]
    public void getTitle()
    {
        Assert.That(toDoItem.title, Is.EqualTo("title"));
    }

    [Test]
    public void getDetail()
    {
        Assert.That(toDoItem.detail, Is.EqualTo("detail"));
    }

    [Test]
    public void getDate()
    {
        string temporary = toDoItem.dateAndTime;
        Assert.Pass();
    }
}