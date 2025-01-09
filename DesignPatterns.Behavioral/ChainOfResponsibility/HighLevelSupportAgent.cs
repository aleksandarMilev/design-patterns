namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class HighLevelSupportAgent : ISupportAgent
    {
        public void HandleRequest(string issue)
        {
            if (issue == "System Crash")
            {
                Console.WriteLine("High-level Support: Handling system crash.");
            }
            else
            {
                Console.WriteLine("High-level Support: Unable to handle the issue.");
            }
        }

        public void SetNext(ISupportAgent next) { }
    }
}
