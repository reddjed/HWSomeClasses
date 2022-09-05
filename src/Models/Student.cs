using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSomeClasses.src.Models
{
    internal class Student
    {
        public FullName? Name { get; set; }
        public int Course { get; set; }
        public EducationalProgram? Specialty { get; set; }
    }
}
    