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
        private bool status;
        private DateTime creationdate;

        public TodoItem(string title, string detail, bool status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.creationdate = DateTime.Now;
        }

        public void toggleStatus()
        {
            this.status = !status;
        }

        public string getStatus()
        {
            if (this.status == false)
            {
                return "Uncompleted";
            } else
            {
                return "Completed";
            }
        }
    }
}
