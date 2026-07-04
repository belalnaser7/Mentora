
using Mentora.Domain.Courses.Lessons;
using Mentora.Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses
{
    public class Module:BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
        public int CourseId { get; set; }
        public float? Price { get; set; } 
        public int Order { get; set; }
        public Course Course { get; set; } = default!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<EnrollmentModule> EnrollmentModules { get; set; } = new List<EnrollmentModule>();
        public ICollection<CourseAccessCodeModule> CourseAccessCodeModules { get; set; } = new List<CourseAccessCodeModule>();
    }
}
