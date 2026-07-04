using Mentora.Domin.Common;
using Mentora.Domin.Identity;
using System.Collections;

namespace Mentora.Domain.Courses
{
    public enum EnrollmentStatus
    {
        Pending=0,
        Active=1,
        Cancelled=2
    }
    public class Enrollment:BaseEntity
    {
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }
        public EnrollmentStatus Status { get; set; }

        public string StudentId { get; set; } = string.Empty;

        public Course Course { get; set; } = default!;

        public ApplicationUser Student { get; set; } = default!;
        public ICollection<EnrollmentModule> EnrollmentModules { get; set; } = new List<EnrollmentModule>;
    }
}
