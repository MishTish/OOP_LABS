using System.Collections.Concurrent;

namespace Task_1
{
    public class DistributedSystemNode
    {
        private readonly string _nodeId;
        private readonly ConcurrentDictionary<string, DistributedSystemNode> _network;
        private readonly ConcurrentQueue<string> _messageQueue;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private bool _isActive;

        public event Action<string, string>? StatusChanged;

        public DistributedSystemNode(string nodeId, ConcurrentDictionary<string, DistributedSystemNode> network)
        {
            _nodeId = nodeId;
            _network = network;
            _messageQueue = new ConcurrentQueue<string>();
            _cancellationTokenSource = new CancellationTokenSource();
            _isActive = true;

            NotifyStatus("Active");

            _ = ProcessMessagesAsync(_cancellationTokenSource.Token);
        }

        public string NodeId => _nodeId;

        public void SendMessage(string recipientNodeId, string message)
        {
            if (_network.TryGetValue(recipientNodeId, out var recipientNode))
            {
                recipientNode.ReceiveMessage($"{_nodeId}: {message}");
            }
            else
            {
                Console.WriteLine($"Node {recipientNodeId} not found in the network.");
            }
        }

        public void ReceiveMessage(string message)
        {
            _messageQueue.Enqueue(message);
        }

        public void SetStatus(bool isActive)
        {
            _isActive = isActive;
            NotifyStatus(isActive ? "Active" : "Inactive");
        }

        private void NotifyStatus(string status)
        {
            StatusChanged?.Invoke(_nodeId, status);
        }

        private async Task ProcessMessagesAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (_messageQueue.TryDequeue(out var message))
                {
                    await Task.Delay(100);
                    Console.WriteLine($"Node {_nodeId} processed message: {message}");
                }
                else
                {
                    await Task.Delay(50);
                }
            }
        }

        public void Shutdown()
        {
            _cancellationTokenSource.Cancel();
            NotifyStatus("Inactive");
        }
    }
}
