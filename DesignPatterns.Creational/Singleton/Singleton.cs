namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton<T> 
        where T : class
    {
        private static T? value;
        private readonly static object lockObj = new();

        private Singleton() { }

        public static T GetInstance(Func<T> factoryMethod)
        {
            if (value is null)
            {
                lock (lockObj)
                {
                    value ??= factoryMethod();
                }
            }

            return value;
        }
    }
}
