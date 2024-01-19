using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public enum TodoItemStatus
    {
        DONE, 
        NOT_DONE
    }

    public class TodoItem
    {
        /*
            User story: I want to see a Date and Time the task was created but I do not want it changed.
        */

        private string title, description;
        private TodoItemStatus status;
        public string Title {get { return title; }}
        public string Description {get { return description; }}
        public TodoItemStatus Status {get { return status; }}

        public TodoItem(String title, String description, TodoItemStatus status)
        {
            this.title = title;
            this.description = description;
            this.status = status;                                           
        }

        public void MarkAsDone()
        {
            this.status = TodoItemStatus.DONE;
        }

    }
}
