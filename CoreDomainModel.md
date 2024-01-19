| Classes | Fields | 
|-|-|
| `TodoItem` | `string _title` `string _detail` `string _status` `DateTime _created` |


| Classes | Methods | Scenario | Outputs | 
|-|-|-|-|
| `TodoItem` | `setStatus(string status)` | Change the status of the TodoItem | void |
| | `getStatus()`| Retrieve the current status of the item | string|
|| `getTitle()`| Retrieve the title of the item | string |
|| `getDetail()` | Retrieve the details of the item | string |
|| `getCreationTime()` | Retrieve a copy of the date and time the item was created | DateTime |