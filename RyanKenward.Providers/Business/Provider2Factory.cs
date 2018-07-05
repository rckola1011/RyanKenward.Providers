using RyanKenward.Providers.Models;

namespace RyanKenward.Providers.Business
{
    public class Provider2Factory : ProviderFactoryBase
    {
        /// <summary>
        /// Gets a new instance of Provider2.
        /// </summary>
        /// <returns>The provider.</returns>
        public override IProvider GetProvider()
        {
            return new Provider2();
        }
    }
}