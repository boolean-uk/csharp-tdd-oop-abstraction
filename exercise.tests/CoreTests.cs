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
    public void Test()
    {
        Assert.Pass();
    }

    [Test]
    public void CanGetDateTime()
    {
        DateTime dt = _tditem.getDateTime();
        
        string date = dt.Date.ToString();

        Assert.AreEqual(date, "17/01/2024 0.00.00");

    }

    [Test]
    public void CannotModifyDateTime()
    {
        DateTime dt = _tditem.getDateTime();
        DateTime dtcomp = _tditem.getDateTime();

        string date = dt.ToString();

        dt = DateTime.Now;

        string date2 = dt.ToString();

        Assert.AreEqual(date, dt.ToString());
        Assert.AreNotEqual(date2, dt.ToString());

    }


}