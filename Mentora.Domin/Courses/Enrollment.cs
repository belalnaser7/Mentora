using Mentora.Domin.Common;
using Mentora.Domin.Identity;

namespace Mentora.Domain.Courses
{
    public class Enrollment:BaseEntity
    {
        public long CourseId { get; set; }

        public string StudentId { get; set; } = string.Empty;

        public Course Course { get; set; } = default!;

        public ApplicationUser Student { get; set; } = default!;
    }
}
