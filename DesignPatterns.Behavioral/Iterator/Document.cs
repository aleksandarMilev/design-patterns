namespace DesignPatterns.Behavioral.Iterator
{
    public class Document
    {
        public Document(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; }

        public string Type { get; }

        public void Display() => Console.WriteLine($"Document Name: {this.Name}, Type: {this.Type}");
    }
}
