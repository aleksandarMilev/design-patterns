namespace DesignPatterns.Structural.Proxy
{
    public interface IDatabase<T>
    {
        T Get(string query);
    }
}
