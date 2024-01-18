Domain Model

User Story
I want to see a Date and Time the task was created but I do not want it changed. 
=> Task.getDateTime(),

Class	 | Members                       | Scenario	     | output
--------------------------------------
TodoItem |private DateTime _TimeStamp    |                   
		 |private string _status		 |
		 |public string TimeStamp{get;}  | get _TimeStamp       | string
         |public string Status {get; set}| get; set; _status    | string
		 | setDateTime()				 | gets DateTime Local	| string
