namespace DesignPatterns.Behavioral.Strategy
{
    public class NewUserDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double originalPrice)
        {
            Console.WriteLine("Applying New User Discount...");

            return originalPrice * 0.80;
        }
    }
}
