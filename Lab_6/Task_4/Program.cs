using System.Runtime.Intrinsics.Arm;
using System;

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
    static void Main(string[] args)
    {
        TaskScheduler<Task, int> scheduler = new TaskScheduler<Task, int>(
            (x, y) => y.CompareTo(x),
            () => new Task(),
            task => task.Description = string.Empty
        );
        Console.WriteLine("priority is: higher number, higher priority");
        scheduler.StartConsoleInput();
    }
}