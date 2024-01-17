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

        public TodoItem(String title, String detail, String status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
        }

        public void changeStatus()
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }
    }
}
