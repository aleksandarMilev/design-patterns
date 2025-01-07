namespace DesignPatterns.Structural.Composite.Component
{
    public abstract class FileSystemComponent
    {
        protected FileSystemComponent(string name) => this.Name = name;

        protected string Name { get; } 

        public abstract void Display(int depth);
    }
}
