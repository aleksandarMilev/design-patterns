namespace DesignPatterns.Behavioral.Command
{
    public class LightRemoteControl
    {
        private ICommand? command;
        private readonly List<ICommand> history = [];

        public void SetCommand(ICommand command) => this.command = command;

        public void PressButton()
        {
            if (this.command is not null)
            {
                this.command.Execute();
                this.history.Add(this.command);
            }
        } 

        public void PressUndo()
        {
            if (this.history.Count > 0)
            {
                var lastCommand = this.history[this.history.Count - 1];
                lastCommand.Undo();

                this.history.RemoveAt(this.history.Count - 1);
            }
        }
    }
}
