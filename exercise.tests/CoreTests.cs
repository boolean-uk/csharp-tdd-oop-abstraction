using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        //Quick check to see if a dateTime gets added.

        TodoItem test = new TodoItem("t", "aaa", false);

        Assert.NotNull(test.getDateTime);
    }
    [Test]
    public void statusTest()
    {
        //Also quick check to see if status works
        TodoItem test = new TodoItem("t","aaa",false);

        Assert.NotNull(test.getStatus);
    }
}