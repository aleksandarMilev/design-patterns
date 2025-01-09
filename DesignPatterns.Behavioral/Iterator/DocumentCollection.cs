namespace DesignPatterns.Behavioral.Iterator
{
    public class DocumentCollection : IContainer<Document>
    {
        private readonly List<Document> documents = [];

        public void AddDocument(Document document) => this.documents.Add(document);

        public IIterator<Document> GetIterator() => new DocumentIterator(this.documents);
    }
}
