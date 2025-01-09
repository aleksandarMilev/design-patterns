namespace DesignPatterns.Structural.Bridge
{
    public class AirConditioner : IDevice
    {
        public void TurnOn() => Console.WriteLine("Turning on Air Conditioner");

        public void TurnOff() => Console.WriteLine("Turning off Air Conditioner");

        public void SetVolume(int volume) => Console.WriteLine($"Setting Air Conditioner volume to {volume}");
    }
}
