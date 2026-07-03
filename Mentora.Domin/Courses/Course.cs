using Mentora.Domin.Common;
using Mentora.Domin.Identity;

namespace Mentora.Domain.Courses
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageCourseUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
       // public string Level { get; set; } Entity
        public string OwnerId { get; set; } = string.Empty;
        public ApplicationUser Owner { get; set; } = default!;
        public ICollection<Module> Modules { get; set; } = new List<Module>();
        public ICollection<Enrollment> EnrollmentCourse { get; set; } = new List<Enrollment>();
        public ICollection<CourseAccessCode> GenerateCode { get; set; } = new List<CourseAccessCode>();

    }

}
