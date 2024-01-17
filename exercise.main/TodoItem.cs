namespace exercise.main
{
    public class TodoItem
    {

        public string Title { get; private set; }
        public string Detail { get; private set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; private set; }


        public TodoItem(string title , string detail , string status)
        {
            Title = title;
            Detail = detail;
            Status = status;
            CreatedAt = DateTime.Now;
        }

        public void setStatus(String status)
        {
            Status = status;
        }

        public String getStatus()
        {
            return Status;
        }
    }
}
