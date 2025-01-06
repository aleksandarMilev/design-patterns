namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class PdfDocument : IDocument
    {
        internal PdfDocument() { }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => "I am Pdf doc";
    }
}
