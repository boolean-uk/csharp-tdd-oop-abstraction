using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        public string title;
        public string detail;
        public string status;
        private DateTime CreationDate;

        public TodoItem(String title, String detail, String status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.CreationDate = DateTime.Now;
            
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }

        public string GetCreationDate()
        {
            string date = CreationDate.ToString("yyyy-MM-dd HH:mm:ss");
            return date;
        }
    }
}
