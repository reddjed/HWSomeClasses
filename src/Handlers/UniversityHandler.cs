

using HWSomeClasses.src.Models;

namespace HWSomeClasses.src.Handlers
{
    internal class UniversityHandler
    {

        public University Craete(string name, Locations location, Accreditations accreditation, List<EducationalProgram> programs, List<Student> students, List<Teacher> teachers)
        {
            try
            {
                var university = new University(location, accreditation, programs, students, teachers, name);
                return university;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }
    }
}
