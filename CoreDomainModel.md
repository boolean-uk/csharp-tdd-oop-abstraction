I want to see a Date and Time the task was created but I do not want it changed.   

Class TodoItem

properties:
private string title
private string detail
private string status
public readonly DateTime dateTime;

public void changeStatus(string status)
changes string status to inserted status

public string getStatus()
return: status of this instance

public DateTime()
return: dateTime