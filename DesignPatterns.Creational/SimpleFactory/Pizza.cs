namespace DesignPatterns.Creational.SimpleFactory
{
    public class Pizza
    {
        public Pizza()
            : this("Pepperoni", PizzaSize.Medium, "Cheese") { }

        public Pizza(string name, PizzaSize size, string toppings)
        {
            this.Name = name;
            this.Size = size;
            this.Toppings = toppings;
        }

        public string Name { get; init; }

        public PizzaSize Size { get; init; }

        public string Toppings { get; init; }

        public decimal Price { get; internal set; }

        public override string ToString() => $"{this.Name} Pizza ({this.Size}) with {this.Toppings} - ${this.Price:F2}";
    }
}
