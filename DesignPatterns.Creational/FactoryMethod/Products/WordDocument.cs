namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class WordDocument : IDocument
    {
        internal WordDocument() { }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => "I am Word doc";
    }
}
