using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        // arrange
        string detail = "send letter at the postoffice before 3pm";
        string status = "not done";
        TodoItem todoItem = new TodoItem("send letter", detail, status);

        // act
        string date = todoItem.GetCreationDate();
        string format = "yyyy-MM-dd HH:mm:ss";
        bool result = DateTime.TryParseExact(date, format, null, System.Globalization.DateTimeStyles.None, out _);

        //assert
        Assert.That(result, Is.True);
        
    }
}