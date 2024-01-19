# Domain Model TodoItem

## Entities
### TodoItem
#### Attributes
* titile: string (get,set)- The name of the todo-item.
* details: string (get, set) - Additional optional details.
* isDone: bool (get) - Whether the task is finished or not. Replaces 'status'.
* creationDateTime: DateTime (get) - The date and time of when a task was created.

#### Interfaces/Methods
* MarkComplete: void - Sets `isDone` to true.
* MarkIncomplete:void - Sets `isDone` to false.
* ToString: string - Should have an override for ToString to get a good visual representation of the todo item.