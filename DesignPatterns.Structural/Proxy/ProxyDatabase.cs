namespace DesignPatterns.Structural.Proxy
{
    public class ProxyDatabase<T> : IDatabase<T>
        where T : new()
    {
        private readonly RealDatabase<T> realDatabase = new();
        private readonly Dictionary<string, T> cache = [];

        public T Get(string query)
        {
            if (this.cache.TryGetValue(query, out var value))
            {
                Console.WriteLine("Returning cached result...");

                return value;
            }

            Console.WriteLine("No cache found. Forwarding request to real database...");

            var result = this.realDatabase.Get(query);
            this.cache[query] = result;

            return result;
        }
    }
}
