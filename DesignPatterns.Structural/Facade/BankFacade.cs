namespace DesignPatterns.Structural.Facade
{
    public class BankFacade
    {
        private readonly UserAuthenticator authenticator = new();
        private readonly AccountBalanceChecker balanceChecker = new();
        private readonly TransactionManager transactionManager = new();

        public void TransferMoney(int userId, string password, int fromAccount, int toAccount, decimal amount)
        {
            if (this.authenticator.Authenticate(userId, password))
            {
                if (this.balanceChecker.HasSufficientBalance(fromAccount, amount))
                {
                    this.transactionManager.Transfer(fromAccount, toAccount, amount);

                    Console.WriteLine("Transaction completed successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
        }
    }
}
