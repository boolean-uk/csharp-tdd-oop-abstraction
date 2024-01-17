namespace exercise.main;

public class TodoItem
{

    private string _title;
    private string _detail;
    private string _status;
    private DateTime _created;

    public TodoItem(String title, String detail)
    {
        _title = title;
        _detail = detail;
        _status = "Incomplete";
        _created = DateTime.Now;
    }

    public DateTime getCreationTime()
    {
        throw new NotImplementedException();
    }

    public void Complete()
    {
        throw new NotImplementedException();
    }

    public bool isComplete()
    {
        throw new NotImplementedException();
    }

    public string getTask()
    {
        throw new NotImplementedException(); 
    }
}
