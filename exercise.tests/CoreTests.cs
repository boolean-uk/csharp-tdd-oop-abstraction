namespace exercise.tests;
using exercise.main;
using NUnit.Framework.Constraints;

[TestFixture]
public class CoreTests
{
    [TestCase("running", "run a mile", false)]
    [TestCase("running", "run a mile", true)]

    public void TestConstructor(string title, string detail, bool iscomplete)
    {
        DateTime expected = DateTime.Now;
        TimeSpan tolerance = TimeSpan.FromSeconds(1);

        TodoItem result = new TodoItem(title, detail, iscomplete);

        Assert.That(result.Time, Is.EqualTo(expected).Within(tolerance));
        Assert.That(result.Detail, Is.EqualTo(detail));
        Assert.That(result.Title, Is.EqualTo(title));
        Assert.That(result.IsComplete, Is.EqualTo(iscomplete));
    }

    [TestCase(true)]
    [TestCase(false)]
    public void TestSetComplete(bool initialComplete)
    {
        TodoItem result = new TodoItem("running", "run a mile", initialComplete);
        result.setStatusComplete();
        Assert.IsTrue(result.IsComplete);
    }

    [TestCase(false)]
    [TestCase(true)]
    public void TestSetIncomplete(bool initialComplete)
    {
        TodoItem result = new TodoItem("running", "run a mile", initialComplete);
        result.setStatusIncomplete();
        Assert.IsFalse(result.IsComplete);
    }

    [TestCase("running", "run a mile", true, "walk a mile")]
    public void SetDetail_ShouldUpdateDetail(string title, string detail, bool isComplete, string newDetail)
    {
        TodoItem result = new TodoItem(title, detail, isComplete);
        result.setDetail(newDetail);
        Assert.AreEqual(newDetail, result.Detail);
    }

    [TestCase("   ", "running")]
    [TestCase("walking", "walking")]
    public void SetTitle_ShouldUpdateTitle_WhenValidStringProvided(string input, string expected)
    {
        // Arrange
        TodoItem result = new TodoItem("running", "run a mile", true);

        // Act
        result.setTitle(input);

        // Assert
        Assert.AreEqual(expected, result.Title);
    }
}