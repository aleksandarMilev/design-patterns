namespace DesignPatterns.Structural.Proxy
{
    public class RealDatabase<T> : IDatabase<T>
        where T : new()
    {
        public T Get(string query)
        {
            Console.WriteLine("Querying database... This might take a while.");
            Thread.Sleep(2_000);

            return new T();
        }
    }
}
