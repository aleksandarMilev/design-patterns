namespace DesignPatterns.Creational.Prototype
{
    using System.Text.Json;

    public class MyPrototype : ICloneable
    {
        public class SomeRefType
        {
            public SomeRefType()
                : this("SomeString") { }

            public SomeRefType(string someString) => this.SomeString = someString;

            public string? SomeString { get; }

            public override string ToString() => this.SomeString ?? "null";
        }

        public MyPrototype()
            : this("SomeString", 42, new()) { }

        public MyPrototype(string? someString, int someInt, SomeRefType? refType)
        {
            this.SomeString = someString;
            this.SomeInt = someInt;
            this.RefType = refType;
        }

        public string? SomeString { get; }

        public int SomeInt { get; }

        public SomeRefType? RefType { get; }

        public object Clone()
        {
            var json = JsonSerializer.Serialize(this);
            var cloned = JsonSerializer.Deserialize<MyPrototype>(json);

            return cloned is null ? new() : cloned;
        }

        public override string ToString()
            => $"SomeString value is {this.SomeString}, SomeInt is {this.SomeInt} and RefType is {this.RefType}";
    }
}
