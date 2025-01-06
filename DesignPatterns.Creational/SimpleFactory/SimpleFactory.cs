namespace DesignPatterns.Creational.SimpleFactory
{
    public sealed class SimpleFactory<T>
        where T : class, new()
    {
        public T Create(Func<T>? factoryMethod = null)
            => factoryMethod is null
                ? new T()
                : factoryMethod();
    }
}
