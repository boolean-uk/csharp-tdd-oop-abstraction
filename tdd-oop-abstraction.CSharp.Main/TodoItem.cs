using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        
        private string title;
        private string detail;
        private string status;

        public TodoItem(String title, String detail, String status) {
            this.title = title;
            this.detail = detail;
            this.status = status;
        }
        public String Title { get { return title; } set { title = value; } }
        public String Detail { get { return detail; } set { detail = value; } }
        public String Status { get { return status; } set { status = value; } }
    }
}
