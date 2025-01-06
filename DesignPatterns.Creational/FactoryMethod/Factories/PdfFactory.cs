namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public class PdfFactory : IDocumentFactory
    {
        public IDocument GetDocument() => new PdfDocument();
    }
}
