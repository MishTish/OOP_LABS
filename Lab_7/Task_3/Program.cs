using Task_3;

public class Program
{
    public static async Task Main(string[] args)
    {
        var sharedLog = new SharedLog();
        var cts = new CancellationTokenSource();

        var resources = new[] { "Resource1", "Resource2", "Resource3" };

        var tasks = new[]
        {
            Task.Run(() => SimulateThread("ThreadA", sharedLog, resources, cts.Token)),
            Task.Run(() => SimulateThread("ThreadB", sharedLog, resources, cts.Token)),
            Task.Run(() => SimulateThread("ThreadC", sharedLog, resources, cts.Token))
        };

        await Task.WhenAll(tasks);

        sharedLog.DisplayLog();
    }

    private static async Task SimulateThread(string threadLabel, SharedLog sharedLog, string[] resources, CancellationToken token)
    {
        var random = new Random();
        for (int i = 0; i < 5; i++)
        {
            if (token.IsCancellationRequested)
                break;

            var resource = resources[random.Next(resources.Length)];
            sharedLog.WriteOperation(threadLabel, resource, $"Operation {i + 1}");

            await Task.Delay(random.Next(100, 500));
        }
    }
}