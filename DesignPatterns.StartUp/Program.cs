namespace DesignPatterns.StartUp
{
    using Creational.AbstractFactory.Factories;
    using Creational.Builder;
    using Creational.FactoryMethod.Factories;
    using Creational.SimpleFactory;
    using DesignPatterns.Creational.Prototype;
    using SingletonPattern = Creational.Singleton;

    internal class Program
    {
        private static void Main()
        {
            //Creational
            Singleton();
            SimpleFactory();
            FactoryMethod();
            AbstractFactory();
            Builder();
            Prototype();
        }

        static void Singleton()
        {
            Console.WriteLine("Singleton example:");

            var singleton = SingletonPattern.Singleton.GetInstance();
            Console.WriteLine(singleton);

            Console.WriteLine();
        }

        static void SimpleFactory()
        {
            Console.WriteLine("Simple Factory example:");

            var pizza = PizzaFactory.Create();
            Console.WriteLine(pizza);

            Console.WriteLine();
        }

        static void FactoryMethod()
        {
            Console.WriteLine("Factory Method example:");

            List<ISimpleDocumentFactory> factories = [ new PdfFactory(), new WordFactory() ];

            foreach (var factory in factories)
            {
                factory.GetDocument().Print();
            }

            Console.WriteLine();
        }

        static void AbstractFactory()
        {
            Console.WriteLine("Abstract Factory example:");

            List<IAbstractDocumentFactory> factories = [ new MyDocumentFactory(), new OtherDocumentFactory() ];

            foreach (var factory in factories)
            {
                factory.CreatePdf().Print();
                factory.CreateWord().Print();
            }

            Console.WriteLine();
        }

        static void Builder()
        {
            Console.WriteLine("Builder example:");

            var builder = new MyCarBuilder();
            var director = new CarDirector(builder);
            var car = director.BuildCar();
            Console.WriteLine(car);

            Console.WriteLine();
        }

        static void Prototype()
        {
            Console.WriteLine("Prototype example:");

            var original = new MyPrototype("SomeString", 42, new());
            var copy = original.Clone();
            Console.WriteLine(copy);

            Console.WriteLine();
        }
    }
}
