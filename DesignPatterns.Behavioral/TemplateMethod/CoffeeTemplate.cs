namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class CoffeeTemplate
    {
        public void MakeCoffee()
        {
            this.BoilWater();
            this.BrewCoffee();
            this.PourIntoCup();
            this.AddCondiments();
        }

        protected abstract void BrewCoffee();

        protected abstract void AddCondiments();

        private void BoilWater() => Console.WriteLine("Boiling water");

        private void PourIntoCup() => Console.WriteLine("Pouring into cup");
    }
}
