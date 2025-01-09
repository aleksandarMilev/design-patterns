namespace DesignPatterns.Structural.Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee coffee;

        public CoffeeDecorator(ICoffee coffee) => this.coffee = coffee;

        public virtual double GetCost() => this.coffee.GetCost();

        public virtual string GetDescription() => this.coffee.GetDescription();

        public override string ToString() => $"{this.GetDescription()} : ${this.GetCost()}";
    }
}
