namespace DesignPatterns.StartUp
{
    using Creational.AbstractFactory.Factories;
    using Creational.Builder;
    using Creational.FactoryMethod.Factories;
    using Creational.FluentInterface;
    using Creational.ObjectPool;
    using Creational.Prototype;
    using Creational.SimpleFactory;
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
            FluentInterface();
            ObjectPool();
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

            var original = new MyPrototype();
            Console.WriteLine("The Original is: " + original);

            var copy = original.Clone();
            Console.WriteLine("The Copy is: " + copy);

            Console.WriteLine();
        }

        static void FluentInterface()
        {
            Console.WriteLine("Fluent Interface example:");

            var person = new PersonBuilder()
                .HasFirstName("John")
                .HasLastName("Doe")
                .HasAge(26)
                .HasGender("female")
                .IsStudent(false)
                .Build();

            Console.WriteLine(person);

            Console.WriteLine();
        }

        static void ObjectPool()
        {
            Console.WriteLine("Object Pool example:");

            var pool = new ObjectPool<Connection>(() => new Connection("MyConnectionString"));

            var connection1 = pool.Rent();
            connection1.Open();

            var connection2 = pool.Rent();
            connection2.Open();

            pool.Return(connection1);
            pool.Return(connection1);

            var connection3 = pool.Rent();
            connection3.Open();
            pool.Return(connection3);

            Console.WriteLine();
        }
    }
}
