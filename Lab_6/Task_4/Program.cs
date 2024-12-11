using System.Runtime.CompilerServices;
namespace lol { class lolol { class lololol { } } }

public class Task : ITaskDescription
{
    public string Description { get; set; }

    public override string ToString()
    {
        return Description;
    }
}


class Program
{
    static int Termin()
    {
        int a = 1;
        int b = 3;
        if (a != 5) return a + b;
        else return 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Termin());
        TaskScheduler<Task, int> scheduler = new TaskScheduler<Task, int>(
            (x, y) => y.CompareTo(x),
            () => new Task(),
            task => task.Description = string.Empty
        );
        Console.WriteLine("priority is: higher number, higher priority");
        scheduler.StartConsoleInput();


    }
}