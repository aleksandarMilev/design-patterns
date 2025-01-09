namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class MediumLevelSupportAgent : ISupportAgent
    {
        private ISupportAgent? nextAgent;

        public void HandleRequest(string issue)
        {
            if (issue == "Password Recovery")
            {
                Console.WriteLine("Medium-level Support: Handling password recovery.");
            }
            else if (this.nextAgent is not null)
            {
                Console.WriteLine("Medium-level Support: Passing to the next agent.");

                this.nextAgent.HandleRequest(issue);
            }
        }

        public void SetNext(ISupportAgent next) => this.nextAgent = next;
    }
}
