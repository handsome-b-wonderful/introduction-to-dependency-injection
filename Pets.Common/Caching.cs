using System;
using System.Runtime.Caching;

namespace Pets.Common
{
    public static class Caching
    {

        // USAGE:
        // int resultOfExpensiveQuery = GetObjectFromCache<int>(id, 10, CallSlowQueryFromDatabase);

        public static T GetObjectFromCache<T>(int cacheItemId, int cacheTimeInMinutes, Func<int, T> objectSetterFunction)
        {
            var cache = MemoryCache.Default;
            var cachedObject = (T)cache[cacheItemId.ToString()];
            if (cachedObject == null)
            {
                var policy = new CacheItemPolicy()
                    { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheTimeInMinutes) };
                cachedObject = objectSetterFunction(cacheItemId);
                cache.Set(cacheItemId.ToString(), cachedObject, policy);
            }
            return cachedObject;
        }
    }
}
