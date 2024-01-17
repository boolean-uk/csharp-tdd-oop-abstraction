using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void TestCanGetDateTime()
    {
        //setup
        DateTime before = DateTime.Now;
        TodoItem item = new("SomeTitle", "Dont forget to do this");

        //execute
        DateTime created = item.GetCreationTime();

        //verify
        Assert.That(created, Is.GreaterThan(before));
        Assert.That(created, Is.LessThan(DateTime.Now));
    }
}