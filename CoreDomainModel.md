Class: TodoItem

Properties:

Title (string): The title of the to-do item. It is private and can only be set during object creation.
Detail (string): The detail of the to-do item. It is private and can only be set during object creation.
IsComplete (bool): The status of the to-do item. It can be publicly get.
CreatedAt (DateTime): The date and time when the to-do item was created. It is private and can only be set during object creation.

Methods:

TodoItem(string title, string detail, string status): A constructor that creates a new TodoItem object with the given title, detail, and status.
SetComplete(): Sets the status of the to-do item to complete. Does not return a value.
SetIncomplete(): Sets the status of the to-do item to incomplete. Does not return a value.