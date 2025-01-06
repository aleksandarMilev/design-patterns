namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    using Products;

    public interface IAbstractDocumentFactory
    {
        PdfDocument CreatePdf();

        WordDocument CreateWord();
    }
}
