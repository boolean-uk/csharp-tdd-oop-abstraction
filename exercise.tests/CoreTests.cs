using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        TodoItem test = new TodoItem("t","aaa",false);

        Assert.NotNull(test.getDateTime);
    }
}