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

        public TodoItem(string title, string detail, bool status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
        }

        public void setComplete()
        {
            this.status = true;
        }

        public void setIncomplete()
        {
            this.status = false;
        }

        public bool isComplete() 
        {
            return this.status;
        }
    }
}
