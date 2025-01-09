namespace DesignPatterns.Structural.Adapter
{
    public class PayPalPayment
    {
        public void MakePayment(decimal amount) => Console.WriteLine($"PayPal: Processing payment of ${amount}");
    }
}
