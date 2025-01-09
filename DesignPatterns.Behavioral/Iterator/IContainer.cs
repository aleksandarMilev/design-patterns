namespace DesignPatterns.Behavioral.Iterator
{
    public interface IContainer<T>
    {
        IIterator<T> GetIterator();
    }
}
