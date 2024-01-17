using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        TodoItem todo = new TodoItem("Help grandma","Buy groceries for grandma");
        Assert.That(todo.getStatus().Equals("incomplete"));
        todo.changeStatus();
        Assert.That(todo.getStatus().Equals("complete"));
    }
    [Test]
    public void dateTest()
    {
        TodoItem todo = new TodoItem("Help grandma", "Buy groceries for grandma");
        string expected = DateTime.Now.ToString();
        Assert.That(expected, Is.EqualTo(todo.getTime()));
    }
}