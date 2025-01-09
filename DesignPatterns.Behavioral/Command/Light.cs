namespace DesignPatterns.Behavioral.Command
{
    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light is ON");

        public void TurnOff() => Console.WriteLine("Light is OFF");
    }
}
