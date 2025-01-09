namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class LowLevelSupportAgent : ISupportAgent
    {
        private ISupportAgent? nextAgent;

        public void HandleRequest(string issue)
        {
            if (issue == "Login Issue")
            {
                Console.WriteLine("Low-level Support: Handling login issue.");
            }
            else if (this.nextAgent is not null)
            {
                Console.WriteLine("Low-level Support: Passing to the next agent.");

                this.nextAgent.HandleRequest(issue);
            }
        }

        public void SetNext(ISupportAgent next) => this.nextAgent = next;
    }
}
