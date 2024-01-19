I want to see a Date and Time the task was created but I do not want it changed.   

Class TodoItem

properties:
private string title
private string detail
private string status
public readonly DateTime dateTime;

public void changeStatus()
changes status to other state (complete/incomplete)

public string getStatus()
return: status of this instance

public DateTime()
return: dateTime