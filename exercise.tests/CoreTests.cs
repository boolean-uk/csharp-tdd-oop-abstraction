using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        TodoItem todo = new TodoItem("Help grandma","Buy groceries for grandma", "incomplete");
        Assert.That(todo.getStatus().Equals("incomplete"));
        todo.changeStatus("complete");
        Assert.That(todo.getStatus().Equals("complete"));
    }
    [Test]
    public void dateTest()
    {
        TodoItem todo = new TodoItem("Help grandma", "Buy groceries for grandma", "incomplete");
        string expected = DateTime.Now.ToString();
        Assert.That(expected, Is.EqualTo(todo.getTime()));
    }
}