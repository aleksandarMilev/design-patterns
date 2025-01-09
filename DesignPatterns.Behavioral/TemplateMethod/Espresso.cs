namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Espresso : CoffeeTemplate
    {
        protected override void BrewCoffee() => Console.WriteLine("Brewing espresso");

        protected override void AddCondiments() => Console.WriteLine("Adding sugar to espresso");
    }
}
