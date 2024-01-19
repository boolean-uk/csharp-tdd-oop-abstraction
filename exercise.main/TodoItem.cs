using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        public string Title {get;set;} 
        public string Detail { get; set; }


        private bool completed;
        public DateTime Created { get; private set; }

        public TodoItem(String title, String detail)
        {
            this.Title = title;
            this.Detail = detail;

            this.completed = false;
            this.Created = DateTime.Now;
        }
       
        public void ChangeCompletedStatus()
        {
            this.completed = !this.completed;
        }

        public bool IsCompleted()
        {
            return this.completed;
        }
    }
}
