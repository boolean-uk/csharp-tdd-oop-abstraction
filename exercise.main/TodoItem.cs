using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        public string title { get; }
        public string detail { get; }
        private string status;
        public string dateAndTime { get; }

        public TodoItem(String title, String detail, String status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            dateAndTime = DateTime.Now.ToString("yyyy - mm - dd HH:mm:ss");
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }
    }
}
