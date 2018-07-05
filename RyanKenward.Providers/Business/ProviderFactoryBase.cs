using RyanKenward.Providers.Models;

namespace RyanKenward.Providers.Business
{
    public abstract class ProviderFactoryBase
    {
        public abstract IProvider GetProvider();
    }
}
