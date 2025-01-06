namespace DesignPatterns.Creational.Builder
{
    using Builders;
    using Product;

    public class MyCarBuilder : ICarBuilder
    {
        private readonly Car car = new();

        public void BuildEngine() => this.car.Engine = "Some Engine";

        public void BuildWheels() => this.car.Wheels = 4;

        public void BuildTransmission() => this.car.Transmission = "Some Transmission";

        public void BuildColor() => this.car.Color = "Red";

        public Car Build() => this.car;
    }
}
