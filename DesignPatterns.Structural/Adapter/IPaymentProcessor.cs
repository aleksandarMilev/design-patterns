namespace DesignPatterns.Structural.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
