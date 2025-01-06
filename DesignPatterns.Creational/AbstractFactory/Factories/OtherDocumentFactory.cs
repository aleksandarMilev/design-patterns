namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    using Products;

    public class OtherDocumentFactory : IAbstractDocumentFactory
    {
        public PdfDocument CreatePdf() => new(nameof(OtherDocumentFactory));

        public WordDocument CreateWord() => new(nameof(OtherDocumentFactory));
    }
}
