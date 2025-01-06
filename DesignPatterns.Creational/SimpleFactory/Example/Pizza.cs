namespace DesignPatterns.Creational.SimpleFactory.Example
{
    public class Pizza
    {
        public Pizza()
            : this("Pepperoni", PizzaSize.Medium, "Cheese")
        {
        }

        public Pizza(string name, PizzaSize size, string toppings)
        {
            this.Name = name;
            this.Size = size;
            this.Toppings = toppings;

            this.Price = this.GetPrice();
        }

        public string Name { get; init; }

        public PizzaSize Size { get; init; }

        public string Toppings { get; init; }

        public decimal Price { get; private set; }

        public override string ToString() => $"{this.Name} Pizza ({this.Size}) with {this.Toppings} - ${this.Price:F2}";

        private decimal GetPrice() 
            => this.Size switch
                {
                    PizzaSize.Small => 8.99m,
                    PizzaSize.Medium => 12.99m,
                    PizzaSize.Large => 16.99m,
                    _ => 12.99m,
                };
    }
}
