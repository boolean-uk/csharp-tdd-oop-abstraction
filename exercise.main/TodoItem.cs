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
        private DateTime dt;

        public TodoItem(String title, String detail, String status)
        {
            dt = DateTime.Now;
            this.title = title;
            this.detail = detail;
            this.status = status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }

        public DateTime getCreationDate() { return this.dt; }
    }
}
