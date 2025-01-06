namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton value = new();
        private readonly static object lockObj = new();

        private Singleton() { }

        public static Singleton GetInstance(Func<Singleton>? factoryMethod = null)
        {
            if (factoryMethod is null)
            {
                if (value is null)
                {
                    lock (lockObj)
                    {
                        value ??= new();
                    }
                }

                return value;
            }

            if (value is null)
            {
                lock (lockObj)
                {
                    value ??= factoryMethod();
                }
            }

            return value;
        }

        public override string ToString() => "I am Singleton";
    }
}
