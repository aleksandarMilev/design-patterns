namespace DesignPatterns.Creational.FluentInterface
{
    public class Person
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string Gender { get; set; } = null!;

        public bool IsStudent { get; set; }

        public override string ToString()
            => $"{this.FirstName} {this.LastName} at {this.Age} old, from {this.Gender} gender, {(this.IsStudent ? "is" : "is not")} student";
    }
}
