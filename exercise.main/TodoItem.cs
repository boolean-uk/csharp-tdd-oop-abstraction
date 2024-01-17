
namespace exercise.main
{
    public class TodoItem
    {

        private string _title;
        private string _detail;
        private bool _isCompleted;
        private readonly DateTime _createdAt;

        public TodoItem(string title, string detail)
        {
            _title = title;
            _detail = detail;
            _isCompleted = false;
            _createdAt = DateTime.Now;
        }

        public void SetComplete()
        {
            _isCompleted = true;
        }
        public void SetIncomplete()
        {
            _isCompleted = false;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public void SetDetails(string detail)
        {
            _detail = detail;
        }

        public string GetTitle() { return _title; }
        public string GetDetails() { return _detail; }
        public bool GetStatus()
        {
            return _isCompleted;
        }

        public DateTime GetCreationTime()
        {
            return _createdAt;
        }
    }
}
