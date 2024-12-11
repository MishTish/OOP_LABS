namespace Task_3
{
    using System;
    using System.Collections.Concurrent;

    public class FunctionCache<TKey, TResult>
    {

        public delegate TResult Func(TKey key);

        private readonly ConcurrentDictionary<TKey, CacheItem> _cache = new();

        private class CacheItem
        {
            public TResult Value { get; }
            public DateTime Expiration { get; }

            public CacheItem(TResult value, DateTime expiration)
            {
                Value = value;
                Expiration = expiration;
            }

            public bool IsExpired => DateTime.UtcNow > Expiration;
        }

        public TResult GetOrAdd(TKey key, Func function, TimeSpan? expiration = null)
        {
            if (_cache.TryGetValue(key, out CacheItem cacheItem))
            {
                if (!cacheItem.IsExpired)
                {
                    return cacheItem.Value;
                }
                Console.WriteLine("Item expired, Creating new");
                _cache.TryRemove(key, out _);
            }

            TResult result = function(key);
            var expirationTime = expiration.HasValue
                ? DateTime.UtcNow.Add(expiration.Value)
                : DateTime.MaxValue;

            _cache[key] = new CacheItem(result, expirationTime);

            return result;
        }

        public void Clear()
        {
            _cache.Clear();
        }

        public bool Remove(TKey key)
        {
            return _cache.TryRemove(key, out _);
        }
    }
}
