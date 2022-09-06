namespace HWSomeClasses.src.Models
{
    internal class Person
    {
        protected string? name;
        protected string? surname;
        protected string? lastName;
        public Person(string? name, string? surname, string? lastName)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Fullname cant be null or empty");
            }
            this.name = name;
            this.surname = surname;
            this.lastName = lastName;
        }
    }
}
