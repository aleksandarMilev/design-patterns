namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class PdfDocument : IDocument
    {
        internal PdfDocument(string createdBy) => this.CreatedBy = createdBy;

        public string CreatedBy { get; }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => $"I am Pdf doc and I am created by {this.CreatedBy}";
    }
}
