using RyanKenward.Providers.Models;

namespace RyanKenward.Providers.Business
{
    public class Provider2Factory : ProviderFactoryBase
    {
        public Provider2Factory()
        {
        }

        public override IProvider GetProvider()
        {
            return new Provider2();
        }
    }
}