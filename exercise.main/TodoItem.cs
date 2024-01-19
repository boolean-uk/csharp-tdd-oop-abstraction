using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main;

    public enum TodoItemStatus { DONE, NOT_DONE }

    public class TodoItem
    {

        private string title;
        private string detail;
        private TodoItemStatus status;
        private DateTime dateTime;

        public string Title { get { return title;  } }
        public string Detail { get { return detail; } }

        public TodoItemStatus Status { get { return status; } }

        public DateTime DateTime { get { return dateTime; } }

        public TodoItem(string title, string detail, TodoItemStatus status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.status = status;
            this.dateTime = DateTime.Now;
        }

        public void setDone()
        {
            this.status = TodoItemStatus.DONE;
        }

        public void setNotDone()
        {
            this.status = TodoItemStatus.NOT_DONE;
        }
  
}
