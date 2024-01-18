using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        // title, details, status
        TodoItem todoitem1 = new TodoItem("Shopping", "Go to the shop", "Not completed");  
        TodoItem todoitem2 = new TodoItem("Grabage", "Take garbage out", "Started");  
        TodoItem todoitem3 = new TodoItem("Dinner", "Do something better then frozen pizza", "Impossible");

        Assert.IsTrue((DateTime.Now - todoitem1.getDateTime()).TotalSeconds < 1); 
        Assert.That(todoitem1.getStatus(), Is.EqualTo("Not completed"));
        



    }
}