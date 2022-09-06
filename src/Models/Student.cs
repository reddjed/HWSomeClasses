namespace HWSomeClasses.src.Models
{
    internal class Student : Person
    {
        public Student(uint course, EducationalProgram? specialty, string? name, string? surname, string? lastname) 
            : base(name,surname,lastname)
        {
            Course = course;
            Specialty = specialty;
            
        }

        public uint Course { get; set; }
        public EducationalProgram? Specialty { get; set; }
    }
}
    