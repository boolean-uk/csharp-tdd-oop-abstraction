using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestDateTime()
    {
        TodoItem todoItem = new TodoItem("clean House", "Every nook and cranny", "Not complete");

        Console.WriteLine(todoItem.getCreationDate());

        
    }
}