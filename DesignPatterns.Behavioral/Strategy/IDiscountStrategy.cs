namespace DesignPatterns.Behavioral.Strategy
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double originalPrice);
    }
}
