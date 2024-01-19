using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [TestCase("Help grandma", "Buy groceries for grandma")]
    [TestCase("", "")]
    [TestCase("", "Buy groceries for grandma")]
    [TestCase("Help grandma", "")]
    public void createTodoItemTest(string title, string detail)
    {
        TodoItem todo = new TodoItem(title, detail);
        Assert.That(todo.Title, Is.EqualTo(title));
        Assert.That(todo.Detail, Is.EqualTo(detail));
    }
    [Test]
    public void statusTest()
    {
        TodoItem todo = new TodoItem("Help grandma","Buy groceries for grandma");
        Assert.IsFalse(todo.getStatus());
        todo.changeStatus();
        Assert.IsTrue(todo.getStatus());
    }
    [Test]
    public void dateTest()
    {
        TodoItem todo = new TodoItem("Help grandma", "Buy groceries for grandma");
        string expected = DateTime.Now.ToString();
        Assert.That(expected, Is.EqualTo(todo.getTime()));
    }
}