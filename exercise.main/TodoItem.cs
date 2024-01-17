using System;

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
        _created = new DateTime(_created.Year, _created.Month, _created.Day, _created.Hour, _created.Minute, _created.Second);
    }
    public DateTime getCreationTime()
    {
        return _created;
    }
    public void Complete()
    {
        _status = "Completed";
    }
    public bool isComplete()
    {
        if (_status == "Completed") return true;
        return false;
    }

    public string getTask()
    {
        return $"{_title} {_detail}";
    }
}
