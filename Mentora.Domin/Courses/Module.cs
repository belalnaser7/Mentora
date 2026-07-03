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
        public long CourseId { get; set; }
        public int order { get; set; }
        public Course Course { get; set; } = default!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<Module> Modules { get; set; } = new List<Module>();
    }
}
