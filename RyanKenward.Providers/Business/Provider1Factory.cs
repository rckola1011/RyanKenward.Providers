using RyanKenward.Providers.Models;

namespace RyanKenward.Providers.Business
{
    public class Provider1Factory : ProviderFactoryBase
    {
        /// <summary>
        /// Gets a new instance of Provider1.
        /// </summary>
        /// <returns>The provider.</returns>
        public override IProvider GetProvider()
        {
            return new Provider1();
        }
    }
}
