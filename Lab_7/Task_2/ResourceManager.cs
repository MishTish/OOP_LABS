namespace Task_2
{
    public class ResourceManager
    {
        private readonly List<Resource> _resources;

        public ResourceManager(IEnumerable<Resource> resources)
        {
            _resources = resources.ToList();
        }

        public async Task<bool> AcquireResourcesAsync(IEnumerable<string> resourceNames, int priority, CancellationToken cancellationToken)
        {
            var sortedResources = resourceNames
                .Select(name => _resources.First(r => r.Name == name))
                .OrderBy(r => priority)
                .ToList();

            foreach (var resource in sortedResources)
            {
                if (!await resource.AcquireAsync(1000, cancellationToken))
                {
                    ReleaseResources(sortedResources);
                    return false;
                }
            }

            return true;
        }

        public void ReleaseResources(IEnumerable<Resource> resources)
        {
            foreach (var resource in resources)
            {
                resource.Release();
            }
        }
    }
}
