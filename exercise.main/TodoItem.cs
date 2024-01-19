namespace exercise.main
{
    public class TodoItem
    {
        private string _title;
        private string _detail;
        private string _status;
        private DateTime _time;

        public string Title { get { return _title; } }
        public string Detail { get { return _detail; } }
        public bool IsComplete { get { return _status == "complete"; } }
        public DateTime Time { get { return _time; } }

        public TodoItem(String title , String detail , String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._time = DateTime.Now;
        }

        public void SetComplete()
        {
            this._status = "complete";
        }
        public void SetIncomplete()
        {
            this._status = "incomplete";
        }
        public void SetDetail(String detail)
        {
            this._detail = detail;
        }
    }

}
