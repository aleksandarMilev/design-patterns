namespace DesignPatterns.Structural.Bridge
{
    public class AirConditionerRemoteControl : RemoteControl
    {
        public AirConditionerRemoteControl(IDevice device) 
            : base(device) { }

        public override void TurnOn() => this.device.TurnOn();

        public override void TurnOff() => this.device.TurnOff();

        public override void SetVolume(int volume) => this.device.SetVolume(volume);
    }
}
