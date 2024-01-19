using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {
        private string _title;
        private string _detail;
        private bool _status;
        private readonly string _dateTime;
        public string Title { get { return _title; } }
        public string Detail { get { return _detail; } }
        public TodoItem(String title, String detail)
        {
            _title = title;
            _detail = detail;
            _status = false;
            _dateTime = DateTime.Now.ToString();
        }
        public void changeStatus()
        {
            _status = !_status;
        }
        public bool getStatus()
        {
            return _status;
        }
        public string getTime()
        {
            return _dateTime;
        }
    }
}
