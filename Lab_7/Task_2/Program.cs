using Task_2;

public class Program
{
    public static async Task Main(string[] args)
    {
        List<Resource> resources = new List<Resource>
        {
            new Resource("CPU", 2),
            new Resource("RAM", 2),
            new Resource("Disk", 1)
        };

        ResourceManager resourceManager = new ResourceManager(resources);
        CancellationTokenSource cts = new CancellationTokenSource();

        var tasks = Enumerable.Range(1, 5).Select(async i =>
        {
            int priority = i % 2 == 0 ? 1 : 2;
            bool acquired = await resourceManager.AcquireResourcesAsync(new[] { "CPU", "RAM" }, priority, cts.Token);
            if (acquired)
            {
                Console.WriteLine($"Thread {i} acquired resources.");
                await Task.Delay(500);
                resourceManager.ReleaseResources(resources.Where(r => r.Name == "CPU" || r.Name == "RAM"));
                Console.WriteLine($"Thread {i} released resources.");
            }
            else
            {
                Console.WriteLine($"Thread {i} failed to acquire resources.");
            }
        });

        await Task.WhenAll(tasks);
    }
}