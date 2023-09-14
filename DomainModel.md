# Domain Model 


# User Stories

1.
I want to see a Date and Time the task was created but I do not want it changed.   


| Classes                | Methods                                                 | Scenario                                                                                   | Expected Output                                                                         |
|------------------------|---------------------------------------------------------|--------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| `TodoItem`             | `Constructor(int id, string title, string description)` | `Creating a TodoItem with properties.`                                                     | `A TodoItem object is created with the specified properties.`                           |
|                        | `MarkTodoItemAsCompleted()`                             | `Marking the TodoItem as completed.`                                                       | `TodoItem is marked as completed.`                                                      |
|                        | `MarkTodoItemAsIncomplete()`                            | `Marking the TodoItem as incomplete.`                                                      | `TodoItem is marked as incomplete.`                                                     |
|                        | `TodoItemToString()`                                    | `Formatting a TodoItem as a string.`                                                       | `TodoItem formatted as a string is returned.`                                           |