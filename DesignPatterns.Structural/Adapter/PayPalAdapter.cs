namespace DesignPatterns.Structural.Adapter
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalPayment payPalPayment;

        public PayPalAdapter(PayPalPayment payPalPayment) => this.payPalPayment = payPalPayment;

        public void ProcessPayment(decimal amount) => this.payPalPayment.MakePayment(amount);
    }
}
