using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void CreationDate()
    {
        //Set Up
        TodoItem item = new TodoItem("Wash dishes", "Wash all the dishes.", false);
        //Execute
        item.toggleStatus();
        //Verify
        Assert.That(item.Status, Is.EqualTo(true));
        Assert.IsNotNull(item.CreationDate);
    }
}