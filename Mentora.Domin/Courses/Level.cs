using Mentora.Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses
{
    public class Level :BaseEntity
    {
        public CourselevelEnum Courselevel { get; set; }
        public AcademicYearEnum? AcademicYear { get; set; }
        public short? Semester { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
