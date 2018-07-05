using RyanKenward.Providers.Models;

namespace RyanKenward.Providers.Business
{
    public class Provider1Factory : ProviderFactoryBase
    {
        public Provider1Factory()
        {
        }

        public override IProvider GetProvider()
        {
            return new Provider1();
        }
    }
}
