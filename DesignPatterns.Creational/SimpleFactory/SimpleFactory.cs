namespace DesignPatterns.Creational.SimpleFactory
{
    public sealed class PizzaFactory
    {
        public static Pizza Create()
        {
            var pizza = new Pizza();
            pizza.Price = GetPrice(pizza.Size);

            return pizza;
        }

        private static decimal GetPrice(PizzaSize size)
          => size switch
          {
              PizzaSize.Small => 8.99m,
              PizzaSize.Medium => 12.99m,
              PizzaSize.Large => 16.99m,
              _ => 12.99m,
          };
    }
}
