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
        private string _dateTimeCreatedTask;


        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._dateTimeCreatedTask = GetDateTimeCreatedTask();
        }
        // public string Detail { get => _detail; set => _detail = value; }

        public String GetTitle()
        {
            return _title;
        }
        public void SetTitle(String title)
        {
            this._title = title;
        }

        public String GetDetail() 
        {
            return _detail;
        }

        public void SetDetail(String detail)
        {
            this._detail = detail;
        }

        public String GetStatus()
        {
            return this._status;
        }

        public void SetStatus(String status)
        {
            this._status = status;
        }

        public string GetDateTimeCreatedTask()
        {
            // returns a formatted DateTime to string.
            Console.WriteLine($"When '{_title} {_detail} {_status}' on todo is created: {_dateTimeCreatedTask}");
            return DateTime.Now.ToString("DAG: dd-MM-yyyy, TIJD HH-mm-ss");
        }
        
    }
}
