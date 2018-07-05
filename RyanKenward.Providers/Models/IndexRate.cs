namespace RyanKenward.Providers.Models
{
    public class IndexRate
    {
        public string Name { get; }
        public int Term { get; }
        public decimal Rate { get; }

        public IndexRate(string name, int term, decimal rate)
        {
            Name = name;
            Term = term;
            Rate = rate;
        }
    }
}
