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
        public Status Status { get; set; }

        public TodoItem(string title, string detail, Status status)
        {
            this.title = title;
            this.detail = detail;
            Status = status;
        }
    }
}
