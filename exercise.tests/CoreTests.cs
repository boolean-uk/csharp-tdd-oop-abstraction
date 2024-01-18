using exercise.main;
using System.Reflection.Emit;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{


    [Test, Order(1)]
    public void Test_01_getStatus_Success()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        bool expectedResult = todoItem.getStatus();
        bool actualResult = true;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(2)]
    public void Test_02_getStatus_Fail()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        bool expectedResult = todoItem.getStatus();
        bool actualResult = false;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }


    [Test, Order(3)]
    public void Test_03_setStatus_Success()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        bool expectedResult = todoItem.setStatus("");
        bool actualResult = true;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(4)]
    public void Test_04_setStatus_Fail()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        bool expectedResult = todoItem.setStatus("");
        bool actualResult = false;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(5)]
    public void Test_05_viewDate()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        DateTime expectedResult = todoItem.viewDate();
        bool actualResult = true;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(6)]
    public void Test_06_setDate_Fail()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", "");

        //Act

        DateTime expectedResult = todoItem.CreationTime = "some date here";
        DateTime actualResult = "some date here";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(!"some date here"));
    }
}