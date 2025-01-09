namespace DesignPatterns.Structural.Decorator
{
    public class Coffee : ICoffee
    {
        public double GetCost() => 1;

        public string GetDescription() => "Coffee, sample";

        public override string ToString() => $"{this.GetDescription()} : ${this.GetCost()}";
    }
}
