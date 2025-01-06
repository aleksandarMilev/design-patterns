namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public class WordFactory : ISimpleDocumentFactory
    {
        public IDocument GetDocument() => new WordDocument();
    }
}
