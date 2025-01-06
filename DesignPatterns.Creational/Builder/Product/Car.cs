namespace DesignPatterns.Creational.Builder.Product
{
    public class Car
    {
        public string? Engine { get; internal set; }

        public int Wheels { get; internal set; }

        public string? Transmission { get; internal set; }

        public string? Color { get; internal set; }

        public override string ToString()
            => $"Car with {this.Engine}, {this.Wheels} wheels, {this.Transmission} transmission, and {this.Color} color.";
    }
}
