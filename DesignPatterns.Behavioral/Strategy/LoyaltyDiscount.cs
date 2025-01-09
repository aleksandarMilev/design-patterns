namespace DesignPatterns.Behavioral.Strategy
{
    public class LoyaltyDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double originalPrice)
        {
            Console.WriteLine("Applying Loyalty Discount...");

            return originalPrice * 0.85; 
        }
    }
}
