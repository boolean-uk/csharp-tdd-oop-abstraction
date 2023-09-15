using NUnit.Framework;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void TitleTest()
        {
            TodoItem todo = new TodoItem("Drink redbull", "Thirsty", false);

            Assert.IsTrue(todo.Title == "Drink redbull");

        }
        [Test]
        public void CreationDate()
        {
            TodoItem todo = new TodoItem("Drink redbull", "Thirsty", false);
            DateTime date = DateTime.Now;
            Assert.IsTrue(date.Year == todo.Created.Year);
            Assert.IsTrue(date.Month == todo.Created.Month);
            Assert.IsTrue(date.Day == todo.Created.Day);
        }

        [Test]
        public void DetailTest() 
        {
            TodoItem todo = new TodoItem("Drink redbull", "Thirsty", false);
            Assert.IsTrue(todo.Detail == "Thirsty");
        }

        [Test]
        public void StatusTest()
         {
            TodoItem todo = new TodoItem("Drink redbull", "Thirsty", false);
            Assert.IsTrue(todo.Status == false);

         
        
        
        }



        }
    }