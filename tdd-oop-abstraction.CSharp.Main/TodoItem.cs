using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        
        public string title;
        private string _detail;
        private string _status;

        public TodoItem(String title, String detail, String status) {
            this.title = title;
            this._detail = detail;
            this._status = status;
        }

        private void setStatus(String status) {
            this._status = status;
        }

        public String getStatus() {
            return this._status;
        }
    }
}
