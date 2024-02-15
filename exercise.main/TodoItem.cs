namespace exercise.main
{
    public class TodoItem
    {
        // Private fields
        private string title;
        private string detail;
        private string status;
        private readonly DateTime creationDateTime;

        // Read-only property for creation date and time
        public DateTime CreationDateTime => creationDateTime;

        // Constructor
        public TodoItem(string title, string detail, string status)
        {
            Title = title;
            Detail = detail;
            Status = status;
            creationDateTime = DateTime.Now;
        }

        // Public properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
