I want to see a Date and Time the task was created but I do not want it changed.   



DOMAIN MODEL;

class TodoItem

Properties 
	private string title
	private string status 
	private string detail
	private readonly creationTimeDate //set at creation

Methods
	getDateAndTime(): String 
	SetComplete(): void
	SetIncomplete(): void
	isComplete(): bool
	GetStatus(): String
	GetTitle(): String 
	GetDetail(): String 