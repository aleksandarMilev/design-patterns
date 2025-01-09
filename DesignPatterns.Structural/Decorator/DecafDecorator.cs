namespace DesignPatterns.Structural.Decorator
{
    public class DecafDecorator : CoffeeDecorator
    {
        public DecafDecorator(ICoffee coffee)
            : base(coffee) { }

        public override double GetCost() => base.GetCost() + 0.5;

        public override string GetDescription() => base.GetDescription() + ", decaf";

        public override string ToString() => base.ToString();
    }
}
