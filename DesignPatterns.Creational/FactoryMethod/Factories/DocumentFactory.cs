namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public interface IDocumentFactory
    {
        IDocument GetDocument();
    }
}
