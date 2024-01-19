using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void GetCreatedTest()
    {
        TodoItem todo = new TodoItem("Test", "Test Test");

        DateTime createdExpected = DateTime.Now;
        DateTime createdActual = todo.Created;

        Assert.That(createdExpected.Second, Is.EqualTo(createdActual.Second));

    }

    [Test]
    public void SetCreatedShouldBeImpossibleTest()
    {
        TodoItem todo = new TodoItem("Test", "Test Test");

        var createdProperty = typeof(TodoItem).GetProperty("Created");
        var setMethod = createdProperty.GetSetMethod();

        Assert.IsNull(setMethod);
    }
}