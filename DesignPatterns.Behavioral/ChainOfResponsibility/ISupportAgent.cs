namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public interface ISupportAgent
    {
        void HandleRequest(string issue);

        void SetNext(ISupportAgent next);
    }
}
