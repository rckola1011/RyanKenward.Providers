using System.Collections.Generic;

namespace RyanKenward.Providers.Models
{
    public interface IProvider
    {
        IEnumerable<IndexRate> GetRates();
    }
}
