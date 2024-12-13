namespace Task_2
{
    public class Resource
    {
        public string Name { get; }
        private readonly SemaphoreSlim _semaphore;

        public Resource(string name, int capacity)
        {
            Name = name;
            _semaphore = new SemaphoreSlim(capacity);
        }

        public async Task<bool> AcquireAsync(int timeout, CancellationToken cancellationToken)
        {
            return await _semaphore.WaitAsync(timeout, cancellationToken);
        }

        public void Release()
        {
            _semaphore.Release();
        }
    }

}
