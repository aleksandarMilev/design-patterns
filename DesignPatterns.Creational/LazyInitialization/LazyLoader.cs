namespace DesignPatterns.Creational.LazyInitialization
{
    public class LazyLoader
    {
        private ExpensiveResource? resource;
        private static readonly object lockObj = new();

        public ExpensiveResource Resource
        {
            get 
            {
                if (this.resource is null)
                {
                    lock (lockObj)
                    {
                        this.resource ??= new();
                    }
                }

                return this.resource;
            }
        }
    }
}
