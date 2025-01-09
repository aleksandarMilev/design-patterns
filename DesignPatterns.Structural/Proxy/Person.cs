namespace DesignPatterns.Structural.Proxy
{
    public class PersonDbModel
    {
        public PersonDbModel()
            : this(42, "Default Name") { }

        public PersonDbModel(int age, string? name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get; }

        public string? Name { get; }
    }
}
