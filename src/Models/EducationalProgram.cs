
//using DataAnnotationsExtensions;
using System.Diagnostics.CodeAnalysis;

namespace HWSomeClasses.src.Models
{
    internal class EducationalProgram
    {
       
        private Dictionary<int, string> _branches;
        private Dictionary<int, string> _specialties;
        [DisallowNull]
        public Dictionary<int, string> Branches
        {
            get => _branches;
            set
            {
                if (value is null || value.Count is 0)
                {
                    throw new ArgumentException(nameof(Branches), nameof(Branches) + " could not be null or empty");
                }

               _branches = value;
            }
        }
        [DisallowNull]
        public Dictionary<int, string> Specialty
        {
            get => _specialties;
            set
            {
                if (value is null || value.Count is 0)
                {
                    throw new ArgumentException(nameof(Specialty), nameof(Specialty) + " could not be null or empty");
                }

                _specialties = value;
            }
        }
        public uint Hours { get; set; }
    }
}