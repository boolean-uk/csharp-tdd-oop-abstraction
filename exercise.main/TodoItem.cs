using System;
using System.Collections.Generic;
using System.Data;
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
        private string _timeStamp;

        public TodoItem(String title, String detail)
        {
            _title = title;
            _detail = detail;
            _status = "Not completed";
            _timeStamp = SetDateTime();

        }

        private string SetDateTime()
        {
            DateTime current = DateTime.Now.ToLocalTime();
            return current.ToString();
        }

        public string Status { get => _status; set => _status = value; }
        public string Title { get => _title;}
        public string Detail { get => _detail; }
        public string TimeStamp { get => _timeStamp; }
    }
}
