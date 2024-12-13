using System.Collections.Concurrent;
using Task_4;

public class Program
{
    public static async Task Main(string[] args)
    {
        var network = new ConcurrentDictionary<string, DistributedEventNode>();

        var nodeA = new DistributedEventNode("NodeA", network);
        var nodeB = new DistributedEventNode("NodeB", network);
        var nodeC = new DistributedEventNode("NodeC", network);

        network.TryAdd(nodeA.NodeId, nodeA);
        network.TryAdd(nodeB.NodeId, nodeB);
        network.TryAdd(nodeC.NodeId, nodeC);

        nodeA.RegisterEvent("Event1");
        nodeB.RegisterEvent("Event1");
        nodeC.RegisterEvent("Event1");

        nodeA.Subscribe("Event1", e => Console.WriteLine($"{e.Publisher} -> NodeA processed {e.Payload} at {e.Timestamp}"));
        nodeB.Subscribe("Event1", e => Console.WriteLine($"{e.Publisher} -> NodeB processed {e.Payload} at {e.Timestamp}"));
        nodeC.Subscribe("Event1", e => Console.WriteLine($"{e.Publisher} -> NodeC processed {e.Payload} at {e.Timestamp}"));

        nodeA.PublishEvent("Event1", "Payload1");
        nodeB.PublishEvent("Event1", "Payload2");
        nodeC.PublishEvent("Event1", "Payload3");

        await Task.Delay(2000);


        var nodeD = new DistributedEventNode("NodeD", network);
        network.TryAdd(nodeD.NodeId, nodeD);

        nodeD.RegisterEvent("Event1");
        nodeD.Subscribe("Event1", e => Console.WriteLine($"{e.Publisher} -> NodeD processed {e.Payload} at {e.Timestamp}"));

        nodeD.PublishEvent("Event1", "Payload4");

        await Task.Delay(2000);

        nodeA.Shutdown();
        nodeB.Shutdown();
        nodeC.Shutdown();
        nodeD.Shutdown();
    }
}