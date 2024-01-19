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
            throw new NotImplementedException();
        }

        public void MarkDone()
        {
            throw new NotImplementedException();
        }

        public void MarkUndone()
        {
            throw new NotImplementedException();
        }

        public string Status()
        {
            throw new NotImplementedException();
        }

        public string Title { get => title; set => title = value; }
        public string Details { get => details; set => details = value; }
        public bool IsDone { get => isDone; }
        public DateTime CreationTime { get => creationTime; }
    }
}
