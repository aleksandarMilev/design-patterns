namespace DesignPatterns.StartUp
{
    using Creational.Singleton;

    internal class Program
    {
        private static void Main()
        {
            //Creational
            //1
            var mySingletonClass = GetSingleton<MyTestClass>();
        }

        //Creational
        //1
        private static T GetSingleton<T>() 
            where T : class, new() 
                => Singleton<T>.GetInstance();
    }

    internal class MyTestClass
    {
        public string? MyProp { get; set; }

        public string? MyMethod() => this.MyProp;
    }
}
