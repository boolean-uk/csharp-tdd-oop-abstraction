## User Story
`I want to see a Date and Time the task was created but I do not want it changed.`

## ToDo 

PROPERTIES
private string _title;
private string _detail;
private string _status;
private DateTime _dateTimeCreatedTask; // creates a DateTime stamp of the created task.


METHODS 
private string GetStatus(); { return _status }; 
private string SetStatus(); { return _status };
private DateTime GetDateTimeCreatedTask(); { return DateTime.Now.ToString(DAG: dd-MM-yyyy, TIJD: HH-mm-ss"); }


```
As a system administrator,
I want my users to have to create a user account with an email address and a password.
```
