using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string _title;
        private string _detail;
        private bool _isComplete;
        private DateTime _time;

        public string Title { get { return _title;  } }
        public string Detail { get { return _detail; } }
        public bool IsComplete { get { return _isComplete; } }
        public DateTime Time { get { return _time; } }

        public TodoItem(String title, String detail, bool isComplete)
        {
            this._title = title;
            this._detail = detail;
            this._isComplete = isComplete;
            this._time = DateTime.Now;
        }

        public void setStatusComplete()
        {
            this._isComplete = true;
        }
        public void setStatusIncomplete()
        {
            this._isComplete = false;
        }
        public void setDetail(String detail)
        {
            this._detail = detail;
        }
        
        public void setTitle(String title)
        {
            if (title.Trim() == "")
                return;
            this._title = title;
        }
    }
}
