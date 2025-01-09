namespace DesignPatterns.Behavioral.Strategy
{
    public class ShoppingCart
    {
        private IDiscountStrategy discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy) => this.discountStrategy = discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy) => this.discountStrategy = discountStrategy;

        public double CalculateFinalPrice(double originalPrice) => this.discountStrategy.ApplyDiscount(originalPrice);
    }
}
