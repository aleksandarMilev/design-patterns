namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Decaf : CoffeeTemplate
    {
        protected override void BrewCoffee() => Console.WriteLine("Brewing decaf coffee");

        protected override void AddCondiments() => Console.WriteLine("Adding milk to decaf coffee");
    }
}
