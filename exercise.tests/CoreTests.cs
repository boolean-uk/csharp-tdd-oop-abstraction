using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    [Test]
    public void CreationDateAndTime()
    {
       
       TodoItem todo = new TodoItem("Title", "detail", "status");

       Assert.That(todo.getCreationDate(), Is.EqualTo(DateTime.Now.Date.ToString()));


       DateTime date = DateTime.Now;
       TodoItem todo2 = new TodoItem("Title", "detail", "status", date);

        Assert.That(todo2.getCreationTime(), Is.EqualTo(string.Format("{0:t}", DateTime.Now)));
       

    }

    [Test]
    public void CreateUser() {
        User user = new User("test", "Valid@Email", "123456789");

        Assert.That(user.Name, Is.EqualTo("test"));
        Assert.That(user.Email, Is.EqualTo("Valid@Email"));
        Assert.IsFalse(user.Enabled);
        

    }

}


