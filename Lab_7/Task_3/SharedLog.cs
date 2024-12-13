using System.Collections.Concurrent;


namespace Task_3
{
    public class SharedLog
    {
        private readonly ConcurrentQueue<(DateTime Timestamp, string ThreadLabel, string Operation)> _log = new();
        private readonly ConcurrentDictionary<string, string> _resourceLocks = new();
        private readonly object _conflictResolutionLock = new();

        public void WriteOperation(string threadLabel, string resource, string operation)
        {
            lock (_conflictResolutionLock)
            {
                if (_resourceLocks.TryGetValue(resource, out string lockedBy) && lockedBy != threadLabel)
                {
                    Console.WriteLine($"Conflict detected: {threadLabel} tried to access {resource}, but it is locked by {lockedBy}.");
                    ResolveConflict(threadLabel, resource);
                }
                else
                {
                    _resourceLocks[resource] = threadLabel;
                    _log.Enqueue((DateTime.Now, threadLabel, operation));
                    Console.WriteLine($"{threadLabel} successfully performed operation on {resource}: {operation}");
                    ReleaseResource(resource, threadLabel);
                }
            }
        }

        public void ResolveConflict(string threadLabel, string resource)
        {
            Console.WriteLine($"Resolving conflict: Allowing {threadLabel} access to {resource}.");
            _resourceLocks[resource] = threadLabel;
        }

        private void ReleaseResource(string resource, string threadLabel)
        {
            if (_resourceLocks.TryRemove(resource, out string lockedBy) && lockedBy == threadLabel)
            {
                Console.WriteLine($"{threadLabel} released lock on {resource}.");
            }
        }

        public void DisplayLog()
        {
            Console.WriteLine("Live Log of Operations:");
            foreach (var entry in _log)
            {
                Console.WriteLine($"[{entry.Timestamp:HH:mm:ss}] Thread: {entry.ThreadLabel}, Operation: {entry.Operation}");
            }
        }
    }

}
