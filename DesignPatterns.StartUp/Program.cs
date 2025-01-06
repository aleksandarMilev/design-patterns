namespace DesignPatterns.StartUp
{
    using Creational.AbstractFactory.Factories;
    using Creational.FactoryMethod.Factories;
    using Creational.SimpleFactory;

    internal class Program
    {
        private static void Main()
        {
            //Creational
            Singleton();
            SimpleFactory();
            FactoryMethod();
            AbstractFactory();
        }

        static void Singleton()
        {
            Console.WriteLine("Singleton example:");

            var singleton = Creational.Singleton.Singleton.GetInstance();
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
    }
}
