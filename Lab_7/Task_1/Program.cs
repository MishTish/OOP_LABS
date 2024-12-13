using System.Collections.Concurrent;
using Task_1;

ConcurrentDictionary<string, DistributedSystemNode> network = new ConcurrentDictionary<string, DistributedSystemNode>();

DistributedSystemNode nodeA = new DistributedSystemNode("NodeA", network);
DistributedSystemNode nodeB = new DistributedSystemNode("NodeB", network);
DistributedSystemNode nodeC = new DistributedSystemNode("NodeC", network);

network.TryAdd(nodeA.NodeId, nodeA);
network.TryAdd(nodeB.NodeId, nodeB);
network.TryAdd(nodeC.NodeId, nodeC);

nodeA.StatusChanged += (nodeId, status) =>
    Console.WriteLine($"{nodeId} is now {status}.");

nodeB.StatusChanged += (nodeId, status) =>
    Console.WriteLine($"{nodeId} is now {status}.");

nodeC.StatusChanged += (nodeId, status) =>
    Console.WriteLine($"{nodeId} is now {status}.");

nodeA.SendMessage("NodeB", "Hello, NodeB!");
nodeB.SendMessage("NodeC", "Hello, NodeC!");
nodeC.SendMessage("NodeA", "Hello, NodeA!");

await Task.Delay(1000);

nodeA.SetStatus(false);

await Task.Delay(500);

nodeA.Shutdown();
nodeB.Shutdown();
nodeC.Shutdown();