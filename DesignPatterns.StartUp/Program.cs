namespace DesignPatterns.StartUp
{
    using Creational.FactoryMethod.Factories;
    using Creational.SimpleFactory;
    using Creational.Singleton;

    internal class Program
    {
        private static void Main()
        {
            //1. Singleton
            var singleton = Singleton.GetInstance();
            Console.WriteLine(singleton);

            //2. Simple Factory
            var pizza = PizzaFactory.Create();
            Console.WriteLine(pizza);

            //3.
            IDocumentFactory pdfFactory = new PdfFactory();
            pdfFactory.GetDocument().Print();

            IDocumentFactory wordFactory = new WordFactory();
            wordFactory.GetDocument().Print();

            //4.
        }
    }
}
