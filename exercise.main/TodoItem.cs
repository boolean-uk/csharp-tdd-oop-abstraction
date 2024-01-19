using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public enum Status
    {
        Done,
        Not_Done
    }
    public class TodoItem
    {

        private string title;
        private string detail;
        private Status status;
        private string date;
        private string time;

        public TodoItem(String title, String detail, Status status, string date, string time)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.date = date;
            this.time = time;
        }

        public void isCompleted()
        {
            this.status = Status.Done;
        }
        public void isNotCompleted()
        {
            this.status = Status.Not_Done;
        }

        public Status getStatus()
        {
            return this.status;
        }
        public void setTitle(String title)
        {
            this.title = title;
        }

        public String getTitle()
        {
            return this.title;
        }
        public void setDetail(String detail)
        {
            this.detail = detail;
        }

        public String getDetail()
        {
            return this.detail;
        }
        public String getDate()
        {
            return this.date;
        }
        public String getTime()
        {
            return this.time;
        }
    }
}
