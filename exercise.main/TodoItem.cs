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

        public TodoItem(String title, String detail)
        {
            this.title = title;
            this.detail = detail;
            this.status = "incomplete";
        }

        public void changeStatus()
        {
            if (this.status == "complete")
                this.status = "incomplete";
            else if (this.status == "incomplete")
                this.status = "complete";
        }

        public String getStatus()
        {
            return this.status;
        }
    }
}
