using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestPrivateFields()
    {
        TodoItem todoItem = new TodoItem("Workout", "Grindset", "Done");

    }
}