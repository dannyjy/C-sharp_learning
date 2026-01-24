using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class CacheService<T>
    {
        public CacheService() { }
        private Dictionary<string, T> _cache = new();
        public void Store(string key, T value) => _cache[key] = value;
        public T Retrieve(string key) => _cache[key];
    }
}