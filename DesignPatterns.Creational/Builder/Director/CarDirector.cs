namespace DesignPatterns.Creational.Builder
{
    using Builders;
    using Product;

    public class CarDirector
    {
        private readonly ICarBuilder builder;

        public CarDirector(ICarBuilder builder) => this.builder = builder;

        public Car BuildCar()
        {
            this.builder.BuildEngine();
            this.builder.BuildWheels();
            this.builder.BuildTransmission();
            this.builder.BuildColor();

            return this.builder.Build();
        }
    }
}
