using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        public string title;
        public string detail;
        public string status;

        public TodoItem(String title, String detail, String status) {
            this.title = title;
            this.detail = detail;
            this.status = status;
        }

        public void setStatus(String status) {
            this.status = status;
        }

        public String getStatus() {
            return this.status;
        }
    }
}
