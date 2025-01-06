namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public interface ISimpleDocumentFactory
    {
        IDocument GetDocument();
    }
}
