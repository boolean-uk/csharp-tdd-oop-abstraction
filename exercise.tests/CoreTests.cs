using Microsoft.VisualBasic;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        exercise.main.DateAndTime dateAndTime = new exercise.main.DateAndTime();

        Assert.That(dateAndTime.GetDate() == DateTime.Now.ToString("dd.MM.yyyy"));
        Assert.That(dateAndTime.GetTime() == DateTime.Now.ToString("t"));
    }
}