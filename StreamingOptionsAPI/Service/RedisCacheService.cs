using Microsoft.Extensions.Caching.Distributed;
using StreamingOptionsAPI.Interface;
using System.Text.Json;

namespace StreamingOptionsAPI.Service
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly IDistributedCache _distributedCache;

        public RedisCacheService(IDistributedCache distributedCache) => _distributedCache = distributedCache;

        public async Task<T>? GetData<T>(string key)
        {
            var data = await _distributedCache.GetStringAsync(key);

            if (data is null)
                return default;
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<T>(data, options);
        }

        public async Task SetData<T>(string key, T data)
        {
            var options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            };
            await _distributedCache.SetStringAsync(key, JsonSerializer.Serialize(data), options);
        }
    }
}
