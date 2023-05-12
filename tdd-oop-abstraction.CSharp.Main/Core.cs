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

        public TodoItem()
        {

        }

        public string Status { get => this.status; set => this.status = value; }
        public string Title { get => this.title; set => this.title = value; }
        public string Detail { get => this.detail; set => this.detail = value; }
    }
}
