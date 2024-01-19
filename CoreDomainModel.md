I want to see a Date and Time the task was created but I do not want it changed.   
verbs/actions: see Date and Time of creation





| Classes             | Members                             | Methods                                                | Scenario                                           | Outputs   |
|---------------------|-------------------------------------|--------------------------------------------------------|----------------------------------------------------|-----------|
| `TodoItem`	      | private bool _status                | todoItem.Status                                        | If task is completed						          | bool      |
|           	      |                                     | todoItem.Status                                        | If task is NOT completed					          | bool      |
|           	      |                                     | todoItem.Status = true                                 | If user wants to mark task completed               |           |
|           	      |                                     | todoItem.Status = false                                | If user wants to mark task NOT done     	          |           |
|           	      | private string _title               | todoItem.Title                                         | returns title                        	          | string    |
|           	      | private string _detail              | todoItem.Detail                                        | returns details                                    | string    |
|           	      | private string _creationTime        | todoItem.CreationTime                                  | returns creation time     	                      | string    |
