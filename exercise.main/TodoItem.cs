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
        private string detail;
        private string status;
        public readonly DateTime dateTime;

        public TodoItem(string title, string detail, string status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            dateTime = DateTime.Now;
        }

        public void setTaskComplete()
        {
            this.status = "complete";
        }

        public void setTaskIncomplete()
        {
            this.status = "incomplete";
        }

        public String getStatus()
        {
            return this.status;
        }

        public DateTime getDateTime()
        {
            return this.dateTime;
        }
    }
}
