using static System.Formats.Asn1.AsnWriter;
using NUnit.Framework;
using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{

    private TodoItem _tditem;

    [SetUp]
    public void SetUp()
    {
        _tditem = new TodoItem("A", "B", "incomplete");
    }


    [Test]
    public void CanGetDateTime()
    {
        DateTime dt = _tditem.getDateTime();
        
        string date = dt.Date.ToString();

        Assert.AreEqual(date, "17/01/2024 0.00.00");

    }

    [Test]
    public void StatusChanging()
    {
        string st1 = _tditem.getStatus();

        Assert.AreEqual(st1, "incomplete");

        _tditem.setTaskComplete();

        Assert.AreEqual(_tditem.getStatus(), "complete");


        _tditem.setTaskIncomplete();

        Assert.AreEqual(_tditem.getStatus(), "incomplete");

    }

}