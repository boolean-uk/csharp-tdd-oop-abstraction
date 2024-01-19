using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public enum TaskStatus
    {
        Done,
        Not_done
    }
    public class TodoItem
    {

        private string _taskTitle;
        private string _taskDetails;
        private TaskStatus _taskStatus;
        private string _dateAndTime;

        public TodoItem(String title, String detail, TaskStatus status)
        {
            _taskTitle = title;
            _taskDetails = detail;
            _taskStatus = status;
            _dateAndTime = DateTime.Now.ToString();
        }

        public string taskTitle { get { return _taskTitle; } }
        public string taskDetails { get { return _taskDetails; } }
        public TaskStatus taskStatus { get { return _taskStatus; } }


        public void SetStatusDone()
        {
            if(_taskStatus == TaskStatus.Not_done) 
            {
                _taskStatus = TaskStatus.Done;
            }
            
        }

        public void SetStatusNotDone()
        {
            if (_taskStatus == TaskStatus.Done)
            {
                _taskStatus = TaskStatus.Not_done;
            }
        }

        public string GetDateAndTime() 
        { 
            return _dateAndTime; 
        }
    }
}
