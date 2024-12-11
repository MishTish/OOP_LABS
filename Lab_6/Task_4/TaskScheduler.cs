using System;
using System.Collections.Generic;

public delegate void TaskExecution<TTask>(TTask task);
public interface ITaskDescription
{
    string Description { get; set; }
}

public class TaskScheduler<TTask, TPriority>
{
    private readonly SortedDictionary<TPriority, Queue<TTask>> _taskQueue;
    private readonly Comparison<TPriority> _priorityComparer;
    private readonly Stack<TTask> _taskPool;
    private readonly Func<TTask> _taskInitializer;
    private readonly Action<TTask> _taskResetter;

    public TaskScheduler(Comparison<TPriority> priorityComparer, Func<TTask> taskInitializer, Action<TTask> taskResetter)
    {
        if (priorityComparer == null)
        {
            throw new ArgumentNullException(nameof(priorityComparer));
        }

        if (taskInitializer == null)
        {
            throw new ArgumentNullException(nameof(taskInitializer));
        }

        if (taskResetter == null)
        {
            throw new ArgumentNullException(nameof(taskResetter));
        }

        _priorityComparer = priorityComparer;
        _taskQueue = new SortedDictionary<TPriority, Queue<TTask>>(Comparer<TPriority>.Create(priorityComparer));
        _taskPool = new Stack<TTask>();
        _taskInitializer = taskInitializer;
        _taskResetter = taskResetter;
    }

    public void AddTask(TPriority priority, string description)
    {
        TTask task = GetTaskFromPool();

        if (task is ITaskDescription taskWithDescription)
        {
            taskWithDescription.Description = description;
        }

        if (!_taskQueue.ContainsKey(priority))
        {
            _taskQueue[priority] = new Queue<TTask>();
        }
        _taskQueue[priority].Enqueue(task);
    }

    public void ExecuteNext(TaskExecution<TTask> execute)
    {
        if (execute == null)
        {
            throw new ArgumentNullException(nameof(execute));
        }

        if (_taskQueue.Count == 0)
        {
            Console.WriteLine("No tasks to execute.");
            return;
        }

        TPriority highestPriority = GetHighestPriority();

        TTask task = _taskQueue[highestPriority].Dequeue();

        if (_taskQueue[highestPriority].Count == 0)
        {
            _taskQueue.Remove(highestPriority);
        }

        execute(task);

        ReturnTaskToPool(task);
    }

    private TTask GetTaskFromPool()
    {
        return _taskPool.Count > 0 ? _taskPool.Pop() : _taskInitializer();
    }

    private void ReturnTaskToPool(TTask task)
    {
        _taskResetter(task);
        _taskPool.Push(task);
    }

    private TPriority GetHighestPriority()
    {
        foreach (TPriority priority in _taskQueue.Keys)
        {
            return priority;
        }
        throw new InvalidOperationException("Task queue is empty.");
    }

    public void StartConsoleInput()
    {
        Console.WriteLine("Enter tasks in the format: <priority> <description>");
        Console.WriteLine("Type 'execute' to execute the next task or 'exit' to quit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == null) continue;
            
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (input.Equals("execute", StringComparison.OrdinalIgnoreCase))
            {
                ExecuteNext(task => Console.WriteLine($"Executing task: {task}"));
                continue;
            }

            string[] parts = input.Split(' ', 2);

            if (parts.Length < 2)
            {
                Console.WriteLine("Invalid input. Please enter in the format: <priority> <description>");
                continue;
            }

            try
            {
                TPriority priority = (TPriority)Convert.ChangeType(parts[0], typeof(TPriority));
                string description = parts[1];
                AddTask(priority, description);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}