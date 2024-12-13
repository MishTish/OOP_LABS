using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class DistributedEventNode
    {
        private readonly string _nodeId;
        private readonly ConcurrentDictionary<string, DistributedEventNode> _network;
        private readonly ConcurrentDictionary<string, List<Action<Event>>> _subscriptions = new();
        private readonly ConcurrentQueue<Event> _eventQueue = new();
        private readonly CancellationTokenSource _cancellationTokenSource = new();
        private int _logicalClock;

        public DistributedEventNode(string nodeId, ConcurrentDictionary<string, DistributedEventNode> network)
        {
            _nodeId = nodeId;
            _network = network;
            _logicalClock = 0;

            _ = ProcessEventsAsync(_cancellationTokenSource.Token);
        }

        public string NodeId => _nodeId;

        public void RegisterEvent(string eventType)
        {
            _subscriptions.TryAdd(eventType, new List<Action<Event>>());
        }

        public void Subscribe(string eventType, Action<Event> handler)
        {
            if (_subscriptions.TryGetValue(eventType, out var handlers))
            {
                handlers.Add(handler);
            }
            else
            {
                Console.WriteLine($"Event type {eventType} is not registered on {_nodeId}.");
            }
        }

        public void PublishEvent(string eventType, string payload)
        {
            var eventId = Guid.NewGuid().ToString();
            var timestamp = Interlocked.Increment(ref _logicalClock);

            var newEvent = new Event(eventId, _nodeId, payload, timestamp);

            foreach (var node in _network.Values)
            {
                node.ReceiveEvent(newEvent);
            }
        }

        public void ReceiveEvent(Event receivedEvent)
        {
            _logicalClock = Math.Max(_logicalClock, receivedEvent.Timestamp) + 1;

            _eventQueue.Enqueue(receivedEvent);
        }

        private async Task ProcessEventsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (_eventQueue.TryDequeue(out var eventToProcess))
                {
                    if (_subscriptions.TryGetValue(eventToProcess.Payload, out var handlers))
                    {
                        foreach (var handler in handlers)
                        {
                            handler(eventToProcess);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{_nodeId} received event of unregistered type: {eventToProcess.Payload}");
                    }
                }

                await Task.Delay(50);
            }
        }

        public void Shutdown()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
