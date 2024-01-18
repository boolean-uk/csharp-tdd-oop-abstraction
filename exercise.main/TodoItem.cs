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
        private string _dateAndTime;

        public string Title { get { return _title; } }
        public string Detail { get { return _detail; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string DateAndTime { get { return _dateAndTime; } }

        public TodoItem(String title, String detail, String status)
        {
            _title = title;
            _detail = detail;
            _status = status;
            _dateAndTime = DateTime.Now.ToString("yyyy - dd - MM HH:mm:ss");
        }
    }
}
