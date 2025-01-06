namespace DesignPatterns.Creational.ObjectPool
{
    public class Connection
    {
        public string ConnectionString { get; }

        public Connection(string connectionString) => this.ConnectionString = connectionString;

        public void Open() => Console.WriteLine("Opening connection: " + this.ConnectionString);

        public void Close() => Console.WriteLine("Closing connection: " + this.ConnectionString);
    }
}
