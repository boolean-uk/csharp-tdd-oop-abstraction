using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string Title;
        private string Detail; 
        private string Status;

        private DateTime date;

        public TodoItem(String title, String detail, String status)
        {
            Title = title;
            Detail = detail;
            Status = status;
            date = DateTime.Now;
        }

        public void setStatus(String status)
        {
            Status = status;
        }

        public string getDate() {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string getStatus()
        {
            return Status;
        }

        public string getDetail()
        {
            return Detail;
        }

        public string getTitle()
        {
            return Title;
        }
    }
}
