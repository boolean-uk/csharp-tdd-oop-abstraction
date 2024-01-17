### Requirements
I want to see a Date and Time the task was created but I do not want it changed.

#### Class
- TodoItem

#### Properties
- private string title;
- private string detail;
- private string status;
- public readonly DateTime dateTime;


#### Methods
- GetDateTime : returns string datetime
- public void seTaskComplete : set string status "complete"
- public void setTaskIncomplete : set string status "incomplete"
- public String getStatus() : get the status