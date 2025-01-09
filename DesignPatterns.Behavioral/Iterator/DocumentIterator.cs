namespace DesignPatterns.Behavioral.Iterator
{
    public class DocumentIterator : IIterator<Document>
    {
        private readonly List<Document> documents;
        private int currentIndex = 0;

        public DocumentIterator(List<Document> documents) => this.documents = documents;

        public bool HasNext() => this.currentIndex < this.documents.Count;

        public Document Next()
        {
            if (this.HasNext())
            {
                return this.documents[this.currentIndex++];
            }

            throw new InvalidOperationException("No more documents to iterate.");
        }
    }
}
