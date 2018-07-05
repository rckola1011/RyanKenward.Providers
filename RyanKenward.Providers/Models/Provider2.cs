using System.Collections.Generic;

namespace RyanKenward.Providers.Models
{
    public class Provider2 : ProviderBase
    {
        /// <summary>
        /// Gets the rates for Provider2.
        /// </summary>
        /// <returns>The rates.</returns>
        public override IEnumerable<IndexRate> GetRates()
        {
            // calls API to get rates
            return new List<IndexRate>
            {
                new IndexRate("LIBOR 1 month", 1, new decimal(0.002333)),
                new IndexRate("LIBOR 6 months", 6, new decimal(0.010999)),
                new IndexRate("LIBOR 12 months", 12, new decimal(0.01333)),
                new IndexRate("LIBOR 24 months", 12, new decimal(0.01666))
            };
        }
    }
}