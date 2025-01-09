namespace DesignPatterns.StartUp
{
    using Creational.AbstractFactory.Factories;
    using Creational.Builder;
    using Creational.FactoryMethod.Factories;
    using Creational.FluentInterface;
    using Creational.LazyInitialization;
    using Creational.ObjectPool;
    using Creational.Prototype;
    using Creational.SimpleFactory;
    using Structural.Adapter;
    using Structural.Bridge;
    using Structural.Composite.Composite;
    using Structural.Composite.Leaf;
    using Structural.Decorator;
    using Structural.Facade;
    using Structural.Flyweight;
    using Structural.Proxy;

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
            Lazy();

            //Structural
            Facade();
            Composite();
            Flyweight();
            Proxy();
            Decorator();
            Adapter();
            Bridge();
        }

        private static void Singleton()
        {
            Console.WriteLine("Singleton example:");

            var singleton = Creational.Singleton.Singleton.GetInstance();
            Console.WriteLine(singleton);

            Console.WriteLine();
        }

        private static void SimpleFactory()
        {
            Console.WriteLine("Simple Factory example:");

            var pizza = PizzaFactory.Create();
            Console.WriteLine(pizza);

            Console.WriteLine();
        }

        private static void FactoryMethod()
        {
            Console.WriteLine("Factory Method example:");

            List<ISimpleDocumentFactory> factories = [ new PdfFactory(), new WordFactory() ];

            foreach (var factory in factories)
            {
                factory.GetDocument().Print();
            }

            Console.WriteLine();
        }

        private static void AbstractFactory()
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

        private static void Builder()
        {
            Console.WriteLine("Builder example:");

            var builder = new MyCarBuilder();
            var director = new CarDirector(builder);
            var car = director.BuildCar();
            Console.WriteLine(car);

            Console.WriteLine();
        }

        private static void Prototype()
        {
            Console.WriteLine("Prototype example:");

            var original = new MyPrototype();
            Console.WriteLine("The Original is: " + original);

            var copy = original.Clone();
            Console.WriteLine("The Copy is: " + copy);

            Console.WriteLine();
        }

        private static void FluentInterface()
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

        private static void ObjectPool()
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

        private static void Lazy()
        {
            Console.WriteLine("Lazy example:");

            var lazyLoader = new LazyLoader();
            var resource = lazyLoader.Resource;
            resource.DoWork();

            Console.WriteLine();
        }

        private static void Facade()
        {
            Console.WriteLine("Facade example:");

            var bankFacade = new BankFacade();
            bankFacade.TransferMoney(
                userId: 1234, 
                password: "password", 
                fromAccount: 1, 
                toAccount: 2, 
                amount: 3000);

            Console.WriteLine();
        }

        private static void Composite()
        {
            Console.WriteLine("Composite example:");

            var file1 = new MyFile("File1.txt");
            var file2 = new MyFile("File2.txt");
            var file3 = new MyFile("File3.txt");

            var rootDirectory = new MyDirectory("Root");
            var subDirectory1 = new MyDirectory("SubDirectory1");
            var subDirectory2 = new MyDirectory("SubDirectory2");

            rootDirectory.Add(file1);
            rootDirectory.Add(subDirectory1);
            subDirectory1.Add(file2);
            subDirectory2.Add(file3);
            rootDirectory.Add(subDirectory2);

            rootDirectory.Display(1);
            Console.WriteLine();
        }

        private static void Flyweight()
        {
            Console.WriteLine("Flyweight example:'");

            var treeFactory = new TreeFactory();

            var oakType = treeFactory.GetTreeType("Oak");
            oakType.Display(1, 2);
            oakType.Display(3, 5);

            var pineType = treeFactory.GetTreeType("Pine");
            pineType.Display(4, 6);
            pineType.Display(7, 8);

            var oakTypeAgain = treeFactory.GetTreeType("Oak");
            oakTypeAgain.Display(9, 10);

            Console.WriteLine();
        }

        private static void Proxy()
        {
            Console.WriteLine("Proxy example:");

            IDatabase<PersonDbModel> dbProxy = new ProxyDatabase<PersonDbModel>();

            dbProxy.Get("SELECT * FROM People");
            dbProxy.Get("SELECT * FROM People");

            Console.WriteLine();
        }

        private static void Decorator()
        {
            Console.WriteLine("Decorator example:");

            ICoffee coffee = new Coffee();
            Console.WriteLine(coffee);

            coffee = new MilkDecorator(coffee);
            Console.WriteLine(coffee);

            coffee = new DecafDecorator(coffee);
            Console.WriteLine(coffee);

            Console.WriteLine();
        }

        private static void Adapter()
        {
            Console.WriteLine("Adapter example:");

            var payPalPayment = new PayPalPayment();
            IPaymentProcessor payPalProcessor = new PayPalAdapter(payPalPayment);
            payPalProcessor.ProcessPayment(1_000);

            Console.WriteLine();
        }

        private static void Bridge()
        {
            Console.WriteLine("Bridge example:");

            IDevice tv = new TV();
            IDevice airConditioner = new AirConditioner();

            RemoteControl tvRemote = new TVRemoteControl(tv);
            RemoteControl acRemote = new AirConditionerRemoteControl(airConditioner);

            tvRemote.TurnOn();
            tvRemote.SetVolume(10);

            acRemote.TurnOn();
            acRemote.SetVolume(5);

            tvRemote.TurnOff();
            acRemote.TurnOff();

            Console.WriteLine();
        }
    }
}
