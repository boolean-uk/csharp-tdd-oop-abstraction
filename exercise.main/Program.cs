using exercise.main;

TodoItem todo = new TodoItem("yupp", "yepp", "nah");
string expected = DateTime.Now.ToString();
todo.getTime();
Console.WriteLine("");