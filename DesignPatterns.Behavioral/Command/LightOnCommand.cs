﻿namespace DesignPatterns.Behavioral.Command
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light) => this.light = light;

        public void Execute() => this.light.TurnOn();

        public void Undo() => this.light.TurnOff();
    }
}
