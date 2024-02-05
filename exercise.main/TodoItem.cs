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
        private string dateTimeCreated;

        public TodoItem(String title, String detail, String status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.dateTimeCreated = getDateTimeCreated();
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public string getDetail()
        {
            return this.detail;
        }

        public void setDetail(String detail)
        {
            this.detail= detail;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }

        public string getDateTimeCreated()
        {
            return "DateTime.Now.ToString(\"yyyy-MM-dd HH:mm:ss\")";
        }
    }
}
