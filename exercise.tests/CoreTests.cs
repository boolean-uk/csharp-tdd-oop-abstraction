using exercise.main;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
	[TestCase("Clean", "Clean Toilet", false)]
	[TestCase("Trash", "Throw out Trash", true)]
	[TestCase("Run", "Run 100 miles!", true)]
	public void Test1(String title, String detail, bool status)
	{
		TodoItem item = new TodoItem(title, detail, status);

		String Title = item.getTitle();
		String Detail = item.getDetail();
		bool Status = item.getStatus();

		Assert.AreEqual(title, Title);
		Assert.AreEqual(detail, Detail);
		Assert.AreEqual(status, Status);
	}

	[Test]
	public void Test2()
	{
		TodoItem item = new TodoItem("Run", "Run alot!", false);

		item.changeStatusComplete();
		bool result = item.getStatus();

		Assert.AreEqual(true, result);

	}

	[Test]
	public void Test3()
	{
		TodoItem item = new TodoItem("Run", "Run alot!", true);

		item.changeStatusIncomplete();
		bool result = item.getStatus();

		Assert.AreEqual(false, result);

	}

	[Test]
	public void Test4()
	{
		TodoItem item = new TodoItem("Run", "Run alot!", true);

		item.PrintDateCreated();

		Assert.Pass(); //how would i test print??

	}
}