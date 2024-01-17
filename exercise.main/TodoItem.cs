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
        private string _status;
        private DateTime _time;

        public string Title { get { return _title;  } }
        public string Detail { get { return _detail; } }
        public string Status { get { return _status; } }
        public DateTime Time { get { return _time; } }

        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._time = DateTime.Now;
        }

        public void setStatusComplete(String status)
        {
            this._status = status;
        }
        public void setStatusIncomplete(String status)
        {
            this._status = status;
        }
        public void setDetail(String detail)
        {
            this._detail = detail;
        }
    }
}
