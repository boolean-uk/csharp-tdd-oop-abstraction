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
        private DateTime _dateTime;

        public TodoItem(string title, string detail, string status)
        {
            _title = title;
            _detail = detail;
            _status = status;
            _dateTime = DateTime.UtcNow;
        }

        public string Title { get { return _title; } set { _title = value; } }
        public string Detail { get { return _detail;} set { _detail = value; } }
        public string Status { get { return _status;} set { _status = value; } }

        public DateTime GetDateTime()
        {
            return _dateTime;
        }
    }
}
