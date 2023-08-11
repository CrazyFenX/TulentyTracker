using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace TulentyTracker.Helpers
{
    internal class MemoryCacheOptionAccessor : IOptions<MemoryCacheOptions>
    {
        public MemoryCacheOptions Value => throw new NotImplementedException();
    }
}
