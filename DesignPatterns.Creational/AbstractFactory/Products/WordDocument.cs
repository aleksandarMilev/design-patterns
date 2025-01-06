namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class WordDocument : IDocument
    {
        internal WordDocument(string createdBy) => this.CreatedBy = createdBy;

        public string CreatedBy { get; }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => $"I am Word doc and I am created by {this.CreatedBy}";
    }
}
