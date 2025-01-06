namespace DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        private readonly Queue<T> availableObjects = new();
        private readonly Func<T> objectGenerator;
        private readonly int maxSize;

        public ObjectPool(Func<T> objectGenerator, int maxSize = 5)
        {
            this.objectGenerator = objectGenerator ?? throw new ArgumentNullException(nameof(objectGenerator));
            this.maxSize = maxSize;
        }

        public T Rent()
        {
            if (this.availableObjects.Count > 0)
            {
                return this.availableObjects.Dequeue();
            }

            return this.objectGenerator();
        }

        public void Return(T item)
        {
            if (this.availableObjects.Count < this.maxSize)
            {
                this.availableObjects.Enqueue(item);
                return;
            }

            Console.WriteLine("Object pool is full. Discarding object.");
        }
    }
}
