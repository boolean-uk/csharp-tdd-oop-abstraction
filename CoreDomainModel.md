I want to see a Date and Time the task was created but I do not want it changed.   
verbs/actions: see Date and Time of creation
method: DateTime viewCreationTime();


| Classes             | Members                             | Methods                                                | Scenario                                           | Outputs   |
|---------------------|-------------------------------------|--------------------------------------------------------|----------------------------------------------------|-----------|
| `TodoItem`	      |                                     | bool getStatus()                                       | If task is completed						          | bool      |
|           	      |                                     |                                                        | If task is NOT completed					          | bool      |
|           	      |                                     | bool setStatus(bool status)                            | If user wants to mark task completed               | bool      |
|           	      |                                     |                                                        | If user wants to mark task NOT done     	          | bool      |
|           	      |                                     | DateTime viewCreationTime()                            |      	                                          | DateTime  |