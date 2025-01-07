namespace DesignPatterns.Structural.Composite.Composite
{
    using Component;

    public class MyDirectory : FileSystemComponent
    {
        private readonly List<FileSystemComponent> components = [];

        public MyDirectory(string name) 
            : base(name) { }

        public void Add(FileSystemComponent component) => this.components.Add(component);

        public void Remove(FileSystemComponent component) => this.components.Remove(component);

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " MyDirectory: " + this.Name);

            foreach (var component in this.components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
