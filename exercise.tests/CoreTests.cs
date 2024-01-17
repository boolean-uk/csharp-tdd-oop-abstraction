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
        _tditem = new TodoItem("A", "B", "D");
    }


    [Test]
    public void CanGetDateTime()
    {
        DateTime dt = _tditem.getDateTime();
        
        string date = dt.Date.ToString();

        Assert.AreEqual(date, "17/01/2024 0.00.00");

    }


}