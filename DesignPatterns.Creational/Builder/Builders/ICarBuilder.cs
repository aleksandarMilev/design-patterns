namespace DesignPatterns.Creational.Builder.Builders
{
    using Product;

    public interface ICarBuilder
    {
        void BuildEngine();

        void BuildWheels();

        void BuildTransmission();

        void BuildColor();

        Car Build();
    }
}
