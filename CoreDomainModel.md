Class

	TodoItem(String Title, String Detail)

Properties

	private readonly string title;
	private readonly string detail;
	private readonly DateTime creationTime;
	Private String status;

Methods

	public string ShowDateAndTime()
		(returns string containing date & time)

	public string SetStatus(String newStatus)
		(updates status)

	public string GetStatus()
		(returns status as string)


Refatcor:

enum TodoItemStatus{

	DONE
	NOT_DONE
}

Class

	TodoItem

Properties

	public readonly string title;
	public readonly string description;
	public readonly string TaskCreationDateTime;
	public readonly TodoItemStatus status;

Methods

	TodoItem(String Title, String Detail, TodoItemStatus status)

	public string getDateTime()
		(returns string containing date & time)

	public string SetDone()
		(//Set status to done)

	public string SetNotDone()
		(// set status to notDone)

	bool SetTitle(string newTitle)

	bool SetDescription(string newDescription)
	