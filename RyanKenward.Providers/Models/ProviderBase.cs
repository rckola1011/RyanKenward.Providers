using System.Collections.Generic;

namespace RyanKenward.Providers.Models
{
    public abstract class ProviderBase : IProvider
    {
        public abstract IEnumerable<IndexRate> GetRates();
    }
}
