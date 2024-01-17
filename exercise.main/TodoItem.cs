using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string _taskTitle;
        private string _taskDetails;
        private string _taskStatus;
        private string _dateAndTime;

        public TodoItem(String title, String detail, String status)
        {
            _taskTitle = title;
            _taskDetails = detail;
            _taskStatus = status;
            _dateAndTime = DateTime.Now.ToString();
        }

        public string taskTitle { get { return _taskTitle; } }
        public string taskDetails { get { return _taskDetails; } }
        public string taskStatus { get { return _taskStatus; } }


        public bool SetStatusDone()
        {
            if(_taskStatus != "Done") 
            {
                _taskStatus = "Done";
                return true;
            }
            else { return false; }
        }

        public bool SetStatusNotDone()
        {
            if (_taskStatus != "Not Done")
            {
                _taskStatus = "Not Done";
                return true;
            }
            else { return false; }
        }

        public string GetDateAndTime() 
        { 
            return _dateAndTime; 
        }
    }
}
