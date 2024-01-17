# TDD

## user stories

I want to see a Date and Time the task was
created but I do not want it changed.

## domain model

class TodoItem
PROPERTIES
    private DateTime _time
    private string _title 
    private string _detail 
    private string _status

	public string Title readonly
	public string Detail readonly
	public string Status readonly
	public string Time readonly

METHODS
constructor(string title, string details, string status)
public void setStatusComplete(string status)
	this._status = "complete"
public void setStatusIncomplete(string status)
	this._status = "incomplete"
public void setDetail(string detail)
	this._detail = detail