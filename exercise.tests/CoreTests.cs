using System.Threading.Tasks.Sources;
using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void getDateTimefromTask()
    {   TodoItem task = new TodoItem(title: "Walk the dog", detail: "Has do be done by today, if not than forget it");
        string getTimeStamp = task.TimeStamp;
        Assert.That(getTimeStamp.Length > 0);
    }
}