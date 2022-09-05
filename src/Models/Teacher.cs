using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSomeClasses.src.Models
{
    internal class Teacher
    {
        public FullName? Name { get; set; }
        public List<EducationalProgram>? Specialties { get; set; }
    }
}
