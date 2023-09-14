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
        private string dateTimeCreated;

        public TodoItem(String title, String detail, string status) {
            this.title = title;
            this.detail = detail;
            this.status = status;
            dateTimeCreated = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        public void setStatus(string status) {
            this.status = status;
        }

        public String getStatus() {
            return this.status;
        }

        public string Title { get => title; }
        public string Detail { get => detail; }
        public string DateTimeCreated { get => dateTimeCreated; }
    }
}
