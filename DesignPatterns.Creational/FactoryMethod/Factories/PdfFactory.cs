namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    using Products;

    public class PdfFactory : ISimpleDocumentFactory
    {
        public IDocument GetDocument() => new PdfDocument();
    }
}
