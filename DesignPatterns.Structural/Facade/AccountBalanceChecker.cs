namespace DesignPatterns.Structural.Facade
{
    public class AccountBalanceChecker
    {
        public bool HasSufficientBalance(int accountId, decimal amount)
        {
            Console.WriteLine($"Checking if account {accountId} has sufficient balance...");

            return amount <= 5000;
        }
    }
}
