



I want to see a Date and Time the task was created but I do not want it changed.  
Class TodoItem

properties 
private string _taskTitle;
private string _taskDetails;
private string _taskStatus;
private string _dateAndTime; stores date and time as a string. gets it from DateTime.Now in the constructor


public string taskTitle {get{return _taskTitle;}}			read only
public string taskDetails {get{return _taskDetails;}}	read only
public string taskStatus {get{return _taskStatus;}}		read only



Methods 

public bool StatusDone() 
-returns true if status was changed to done.
-returns false if status is alrady done.

public bool StatusNotDone()
-returns true if status was changed to NotDone.
-returns false if status is alrady NotDone.

public string GetDateAndTime()
-returns the date and time post was created as a string.







