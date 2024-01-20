I want to see a Date and Time the task was created but I do not want it changed.

```C#
    public class TodoItem
    PROPERTIES:
        private string title
        private string detail
        private bool status
        private DateTime createdAt

    METHODS:
        public TodoItem(String title, String detail)
            Intialize the TodoItem and set createdAt to the current time

        public void setStatusDone()
            set status
        
        public void setStatusNotDone()
            set status

        public string getStatus
            outputs string depending on status state

        public DateTime getTimeCreated()
            outputs createdAt
```