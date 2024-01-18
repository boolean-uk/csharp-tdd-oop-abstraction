using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Core
{
    public class TodoItem
    {

        public string Title { get; }
        public string Detail { get; }
        public bool Finished { get; set; } = false;
        public DateTime DateCreated { get; } = new();

        public TodoItem(string title, string detail)
        {
            Title = title;
            Detail = detail;
        }
    }
}
