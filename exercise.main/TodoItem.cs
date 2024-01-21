using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public enum TodoItemStatus 
    {
        DONE, //=0
        NOT_DONE //=1
    }
    //Class TodoItem
    public class TodoItem
    {
        //Properties
        private string title;
        private string description;
        public readonly string taskCreationDateTime;
        public TodoItemStatus status;

        //Constructor
        public TodoItem(string title, string description, TodoItemStatus status)
        {
            this.title = title;
            this.description = description;
            taskCreationDateTime = DateTime.Now.ToString();
            this.status = status;
        }

        //Setstatus
        public void setDone()
        {
            this.status = TodoItemStatus.DONE;
        }

        //GetStatus
        public void setNotDone()
        {
            this.status = TodoItemStatus.NOT_DONE;
        }

        //Get Title
        public string getTitle() 
        {
            return title;
        }

        //Get description
        public string getDescription()
        {
            return description;
        }

        //GetTime & Date
        public string getDateTime() 
        {
            return this.taskCreationDateTime;
        }

        //SetTitle
        public bool setTitle(string newTitle) 
        {
            if (this.title != newTitle && newTitle.Length > 0 ) 
            {
                this.title = newTitle;
                return true;
            }
            return false;
        }

        //SetDescription
        public bool setDescription(string newDescription)
        {
            if (this.description != newDescription && newDescription.Length > 0)
            {
                this.description = newDescription;
                return true;
            }
            return false;
        }
    }
}
