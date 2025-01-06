namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public interface IDocument
    {
        string CreatedBy { get; }

        void Print();
    }
}
