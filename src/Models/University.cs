namespace HWSomeClasses.src.Models
{
    internal class University
    {
        public University(Locations location, Accreditations accreditation, List<EducationalProgram>? programs, List<Student>? students, List<Teacher>? teachers, string? name)
        {
            if (programs is null || students is null || teachers is null ||
                programs!.Count is 0 || students!.Count is 0 || teachers!.Count is 0)
            {
                throw new ArgumentException("programs, students, teachers cant be null or empty");
            }
            else if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("name cant be null or empty");
            }
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
