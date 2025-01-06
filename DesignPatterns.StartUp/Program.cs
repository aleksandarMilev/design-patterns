namespace DesignPatterns.StartUp
{
    using Creational.SimpleFactory;
    using Creational.SimpleFactory.Example;
    using Creational.Singleton.Example;

    internal class Program
    {
        private static void Main()
        {
            //1. Singleton
            var singleton = MySingletonClass.GetSingleton();
            Console.WriteLine(singleton);

            //2. Simple Factory
            var pizza = new SimpleFactory<Pizza>().Create();
            Console.WriteLine(pizza);

            //3.
        }
    }
}
