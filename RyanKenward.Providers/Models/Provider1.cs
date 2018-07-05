using System.Collections.Generic;

namespace RyanKenward.Providers.Models
{
    public class Provider1 : ProviderBase
    {
        /// <summary>
        /// Gets the rates for Provider1.
        /// </summary>
        /// <returns>The rates.</returns>
        public override IEnumerable<IndexRate> GetRates()
        {
            // calls API to get rates
            return new List<IndexRate>
            {
                new IndexRate("LIBOR 1 month", 1, new decimal(0.004969)),
                new IndexRate("LIBOR 2 months", 2, new decimal(0.006105)),
                new IndexRate("LIBOR 3 months", 3, new decimal(0.007776)),
                new IndexRate("LIBOR 6 months", 6, new decimal(0.011442)),
                new IndexRate("LIBOR 12 months", 12, new decimal(0.014546))
            };
        }
    }
}
