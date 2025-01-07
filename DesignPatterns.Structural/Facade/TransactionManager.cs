namespace DesignPatterns.Structural.Facade
{
    public class TransactionManager
    {
        public void Transfer(int fromAccount, int toAccount, decimal amount) 
            => Console.WriteLine($"Transferring {amount:C} from account {fromAccount} to account {toAccount}.");
    }
}
