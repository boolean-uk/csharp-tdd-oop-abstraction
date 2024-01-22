using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void Test()
    {
        Assert.Pass();
    }


    [Test]
    public void setStatus()
    {
        //Arrange
        TodoItem todo = new TodoItem("write test", "writing test", "incompleted");
        //Act
        todo.Status = "complete";
        //Assert
        Assert.That("complete",Is.EqualTo(todo.Status));
    }

    [Test]
    public void getDateTime() 
    {
        //Arrange
        TodoItem todo = new TodoItem("World domination", "With AI bots and kittens", "started");
        //Act
        string time = DateTime.Now.ToString("yyyy - mm - dd HH:mm");
        //Assert
        Assert.That(time,Is.EqualTo(todo.dateTime)); 
    }

    [Test]
    public void createUser()
    {
        //Arrange
        Admin admin = new Admin();
        admin.createUSerAccount("Sebastianhotmail.com", "pass");

        //Act
        

        //Assert
        

    }
}