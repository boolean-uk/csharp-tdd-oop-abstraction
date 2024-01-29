```
I want to see a Date and Time the task was created but I do not want it changed.
```

| Classes         | Methods                                     | Scenario                                                 | Outputs             |
|-----------------|---------------------------------------------|----------------------------------------------------------|---------------------|
| `DateAndTime`   | `public string GetDate()`                   | Returns the current date from the computer system        | `day.month.year`    |
|                 | `public string GetTime()`                   | Returns the current time from the computer system        | `hour:minutes`      |