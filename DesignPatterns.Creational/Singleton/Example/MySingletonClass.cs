namespace DesignPatterns.Creational.Singleton.Example
{
    public class MySingletonClass
    {
        public MySingletonClass(string myProp) => this.MyProp = myProp;

        public string? MyProp { get; set; }

        public string? MyMethod() => this.MyProp;

        public static MySingletonClass GetSingleton() 
            => Singleton<MySingletonClass>.GetInstance(() => new MySingletonClass("myProp"));

        public override string? ToString() => this.MyProp;
    }
}
