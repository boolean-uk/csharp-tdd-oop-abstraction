namespace exercise.tests;
using exercise.main;
using NUnit.Framework.Constraints;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test1()
    {
        DateTime expected = DateTime.Now;
        TimeSpan tolerance = TimeSpan.FromSeconds(1); // Adjust this based on your acceptable tolerance
        TodoItem result = new TodoItem("running", "run a mile", "incomplete");
        Assert.That(result.Time, Is.EqualTo(expected).Within(tolerance));
    }
}