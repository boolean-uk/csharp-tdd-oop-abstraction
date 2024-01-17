
namespace exercise.main
{
    public class TodoItem
    {

        private string _title;
        private string _detail;
        private string _status;

        public TodoItem(string title, string detail, string status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
        }

        public void setStatus(string status)
        {
            this._status = status;
        }

        public string getStatus()
        {
            return this._status;
        }

        public DateTime GetCreationTime()
        {
            throw new NotImplementedException();
        }
    }
}
