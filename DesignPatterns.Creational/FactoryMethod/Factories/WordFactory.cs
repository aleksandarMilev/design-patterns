namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public class WordFactory : IDocumentFactory
    {
        public IDocument GetDocument() => new WordDocument();
    }
}
