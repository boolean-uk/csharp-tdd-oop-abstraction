using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string _title { get; }
        private string _detail { get; }
        public bool Finished { get; set; } = false;
        public DateTime DateCreated { get; } = new();

        public TodoItem(string title, string detail)
        {
            _title = title;
            _detail = detail;
        }
    }
}
