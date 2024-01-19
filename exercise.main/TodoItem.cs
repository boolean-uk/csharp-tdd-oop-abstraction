using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string title;
        private string details;
        private bool isDone;
        private DateTime creationTime;

        public TodoItem(String title, String details = "")
        {
            this.creationTime = DateTime.Now;
            this.title = title;
            this.details = details;
            this.isDone = false;
        }

        public void MarkDone()
        {
            this.isDone = true;
        }

        public void MarkUndone()
        {
            this.isDone = false;
        }

        public string Status()
        {
            return IsDone ? "Done" : "Pending";
        }

        public string Title { get => title; set => title = value; }
        public string Details { get => details; set => details = value; }
        public bool IsDone { get => isDone; }
        public DateTime CreationTime { get => creationTime; }
    }
}
