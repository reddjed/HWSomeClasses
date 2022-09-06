namespace HWSomeClasses.src.Models
{
    internal class Teacher : Person
    {
        public Teacher(List<EducationalProgram>? specialties, string? name, string? surname, string? lastname)
            : base(name,surname,lastname)
        {
            Specialties = specialties;
        }

        public List<EducationalProgram>? Specialties { get; set; }
    }
}
