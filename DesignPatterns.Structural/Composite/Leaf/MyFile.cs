namespace DesignPatterns.Structural.Composite.Leaf
{
    using Component;

    public class MyFile : FileSystemComponent
    {
        public MyFile(string name) 
            : base(name) { }

        public override void Display(int depth) 
            => Console.WriteLine(new string('-', depth) + " MyFile: " + this.Name);
    }
}
