namespace HWSomeClasses.src.Models
{
    internal class University
    {
        public University(Locations location, Accreditations accreditation, List<EducationalProgram>? programs, List<Student>? students, List<Teacher>? teachers, string? name)
        {
            Location = location;
            Accreditation = accreditation;
            Programs = programs;
            Students = students;
            Teachers = teachers;
            Name = name;
        }
        public string? Name { get; set; }
        public Locations Location { get; set; }
        public Accreditations Accreditation { get; set; }
        public List<EducationalProgram>? Programs { get; set; }
        public List<Student>? Students { get; set; }
        public List<Teacher>? Teachers { get; set; }

    }
}
