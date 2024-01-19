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
        private string date;
        private string time;

        public TodoItem(String title, String detail, String status, string date, string time)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.date = date;
            this.time = time;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
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
