using NUnit.Framework;
using System.ComponentModel;
using tdd_oop_abstraction.CSharp.Main;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void Test_One() // Create a ToDoItem with date and time of creation
        {
            //arrange
            TodoItem testItem = new TodoItem("Study Abstraction", "Exposed vs behind the scenes", "Ongoing");

            //act

            //assert
            Assert.That(testItem.VisibleCreation, Is.InstanceOf<DateTime>());
        }

        [Test]
        public void Test_Two() // Test that creation DateTime cannot be changed
        {
            //arrange
            TodoItem testItem = new TodoItem("Study Abstraction", "Exposed vs behind the scenes", "Ongoing");

            //act
            DateTime dateTimeCorrect = testItem.VisibleCreation;

            //Trying to change the datetime with this will fail, because it is read-only. 
            //testItem.VisibleCreation = DateTime.Now;

            //assert
            Assert.That(testItem.VisibleCreation, Is.EqualTo(DateTime.Now));



            //Attempt at writing a test that gets uses the attributes to determine if the property is Read-only
            // Gets the attributes for the property.
            //AttributeCollection attributes = TypeDescriptor.GetAttributes(testItem.VisibleCreation);

            //AttributeCollection attributes = TypeDescriptor.GetAttributes(testItem.VisibleCreation);
            //var CheckAttributes = attributes[2].TypeId;
            //ReadOnlyAttribute myAttribute = (ReadOnlyAttribute)attributes[typeof(ReadOnlyAttribute)];

            //Assert.IsTrue(myAttribute.IsReadOnly);
        }
    }
}