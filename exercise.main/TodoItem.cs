
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

        public void setComplete()
        {
            _isCompleted = true;
        }
        public void setIncomplete()
        {
            _isCompleted = false;
        }

        public bool getStatus()
        {
            return _isCompleted;
        }

        public DateTime GetCreationTime()
        {
            return _createdAt;
        }
    }
}
