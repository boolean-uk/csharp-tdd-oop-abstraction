#Domain model


```
User story 1
I want to see a Date and Time the task was created but I do not want it changed.   



Class           | Member                        |  Method                     | Output
---------------------------------------------------------------------------------------------------------------------------------------------|
TodoItem        | title                         |                             |                                                              |
                | detail                        |                             |                                                              |       
                | status                        | setStatus(String status)    | Changes status                                               |
                | creationDateTime              |                             | Read-only field representing the date and time of creation.  |
                |                               | getStatus()                 | Retrieves the current status of the task.                    |
                |                               | getCreationDateTime()       | Retrieves the date and time of task creation.                |
----------------------------------------------------------------------------------------------------------------------------------------------

```
