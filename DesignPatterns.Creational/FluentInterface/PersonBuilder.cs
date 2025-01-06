namespace DesignPatterns.Creational.FluentInterface
{
    public class PersonBuilder
    {
        private readonly Person person = new();

        public PersonBuilder HasFirstName(string name)
        {
            this.person.FirstName = name;

            return this;
        }

        public PersonBuilder HasLastName(string name)
        {
            this.person.LastName = name;

            return this;
        }

        public PersonBuilder HasAge(int age)
        {
            this.person.Age = age;

            return this;
        }

        public PersonBuilder HasGender(string gender)
        {
            this.person.Gender = gender;

            return this;
        }

        public PersonBuilder IsStudent(bool isStudent)
        {
            this.person.IsStudent = isStudent;

            return this;
        }

        public Person Build() => this.person;
    }
}
