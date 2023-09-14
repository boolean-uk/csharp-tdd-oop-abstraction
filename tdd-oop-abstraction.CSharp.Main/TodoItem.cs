using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem 
    {      
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public DateTime CreatedAt { get; }

        public bool IsCompleted { get; private set; }

        public TodoItem(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            IsCompleted = false;
        }

        public void MarkTodoItemAsCompleted()
        {
            IsCompleted = true;
        }

        public void MarkTodoItemAsIncomplete()
        {
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Title} - Created At: {CreatedAt}, Completed: {IsCompleted}";
        }
    }
}