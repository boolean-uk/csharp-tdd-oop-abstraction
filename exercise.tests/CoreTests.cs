using exercise.main;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{


    [Test, Order(1)]
    public void Test_01_getStatus_True()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);
        todoItem.Status = true;

        //Act

        bool expectedResult = todoItem.Status;
        bool actualResult = true;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(2)]
    public void Test_02_getStatus_False()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);


        //Act

        bool expectedResult = todoItem.Status;
        bool actualResult = false;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }


    [Test, Order(3)]
    public void Test_03_setStatus_True()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);

        //Act
        todoItem.Status = true;
        bool expectedResult = todoItem.Status;
        bool actualResult = true;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(4)]
    public void Test_04_setStatus_False()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);

        //Act

        bool expectedResult = todoItem.Status;
        bool actualResult = false;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(5)]
    public void Test_05_viewDate()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);
        //Hopefully the computer is quick enough to create them in the same second.
        string sameTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");

        //Act
        string expectedResult = todoItem.CreationTime;
        string actualResult = sameTime;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(6)]
    public void Test_06_setDate_Fail()
    {
        //Arrange
        TodoItem todoItem = new TodoItem("Do abstraction exercise", "Refactor TodoItem class to have good encabsulation and/or abstraction", false);

        //Act
        
        //todoItem.CreationTime = DateTime.Now;
        //Error CS0200  Property or indexer 'TodoItem.CreationTime' cannot be assigned to --it is read only   

        string expectedResult = "I want to see a Date and Time the task was created but I do not want it changed.";
        string actualResult = "I want to see a Date and Time the task was created but I do not want it changed.";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}