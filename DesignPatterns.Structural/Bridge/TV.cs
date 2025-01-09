namespace DesignPatterns.Structural.Bridge
{
    public class TV : IDevice
    {
        public void TurnOn() => Console.WriteLine("Turning on TV");

        public void TurnOff() => Console.WriteLine("Turning off TV");

        public void SetVolume(int volume) => Console.WriteLine($"Setting TV volume to {volume}");
    }
}
