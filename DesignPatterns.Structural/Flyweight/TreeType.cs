namespace DesignPatterns.Structural.Flyweight
{
    public class TreeType
    {
        public TreeType(string species) => this.Species = species;

        public string Species { get; }

        public void Display(int x, int y)
            => Console.WriteLine($"Tree of species {this.Species} at position ({x}, {y})");
    }
}
