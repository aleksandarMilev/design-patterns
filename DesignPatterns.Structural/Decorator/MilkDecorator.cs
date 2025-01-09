namespace DesignPatterns.Structural.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) 
            : base(coffee) { }

        public override double GetCost() => base.GetCost() + 1.5;

        public override string GetDescription() => base.GetDescription() + ", with milk";

        public override string ToString() => base.ToString();
    }
}
