I want to see a Date and Time the task was created but I do not want it changed.

```C#
    public class TodoItem
    PROPERTIES:
        private string title
        private string detail
        private string status
        private DateTime createdAt

    METHODS:
        public TodoItem(String title, String detail, String status)
            Intialize the TodoItem and set createdAt to the current time

        public void setStatus(String status)
            set status

        public String getStatus
            outputs status

        public DateTime getTimeCreated()
            outputs createdAt
```