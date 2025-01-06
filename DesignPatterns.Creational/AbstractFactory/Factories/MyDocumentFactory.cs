namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    using Products;

    public class MyDocumentFactory : IAbstractDocumentFactory
    {
        public PdfDocument CreatePdf() => new(nameof(MyDocumentFactory));

        public WordDocument CreateWord() => new(nameof(MyDocumentFactory));
    }
}
