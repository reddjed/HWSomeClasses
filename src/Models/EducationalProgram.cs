using System.Diagnostics.CodeAnalysis;

namespace HWSomeClasses.src.Models
{
    internal class EducationalProgram
    {

        private Dictionary<int, string> _branches;
        private Dictionary<int, string> _specialties;

        public EducationalProgram(Dictionary<int, string> branches, Dictionary<int, string> specialties, uint hours)
        {
            if (branches is null || specialties is null 
                || branches.Values.Count is 0 || specialties.Values.Count is 0)
            {
                throw new ArgumentException("branches or specialties could not be null or empty");
            }
            else if (hours is 0)
            {
                throw new ArgumentException("hours could not be less then or 0");
            }
            _branches = branches;
            _specialties = specialties;
            Hours = hours;
        }

        [DisallowNull]
        public Dictionary<int, string> Branches
        {
            get => _branches;
            set
            {
                if (value is null || value.Count is 0)
                {
                    throw new ArgumentException("branches could not be null or empty");
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
                    throw new ArgumentException("specialties could not be null or empty");
                }

                _specialties = value;
            }
        }
        public uint Hours { get; set; }
    }
}