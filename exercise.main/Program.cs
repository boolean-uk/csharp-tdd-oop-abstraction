using exercise.main;

public class Program
{ 
    static public void Main(string[] args)
    {
        TodoItem list = new TodoItem("Thing", "Do thing");
        Console.WriteLine(list.getStatus());
        list.changeStatus();
        Console.WriteLine(list.getStatus());
        list.changeStatus();
        Console.WriteLine(list.getStatus());
        list.changeStatus();
        Console.WriteLine(list.getStatus());
    }
}