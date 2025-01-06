namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton<T> 
        where T : class, new()
    {
        private readonly static T value = new();

        private Singleton() { }

        public static T GetInstance() => value;
    }
}
