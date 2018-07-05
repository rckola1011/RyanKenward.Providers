using System;
using System.Text;
using RyanKenward.Providers.Business;

namespace RyanKenward.Providers
{
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// Given a valid provider name, outputs the provider terms and rates.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Length != 1)
                throw new ArgumentException("Please specify a provider name as an argument parameter (Example: \"Provider1\").");

            ProviderFactoryBase providerFactory = null;
            switch (args[0].ToLower())
            {
                case "provider1":
                    providerFactory = new Provider1Factory();
                    break;
                case "provider2":
                    providerFactory = new Provider2Factory();
                    break;
                default:
                    Console.WriteLine($"Provider \"{args[0]}\" not found.");
                    Console.ReadKey();
                    return;
            }

            // factory creates the specified provider
            var provider = providerFactory.GetProvider();
            // gets specific rates for specified provider
            var indexRates = provider.GetRates();

            // builds output of provider details
            var output = string.Empty;
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Your rate options:\n\r");

            foreach (var rate in indexRates)
                stringBuilder.Append($"Name: {rate.Name}; Term: {rate.Term}; Rate: {rate.Rate}\n\r");

            stringBuilder.Append("(Press any key to exit)");
            Console.WriteLine(stringBuilder);
            Console.ReadKey();
        }
    }
}
