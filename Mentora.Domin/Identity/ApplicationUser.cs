using Mentora.Domain.Courses;
using Mentora.Domain.Courses.Lessons.Examination;
using Mentora.Domin.Subscriptions;
using Microsoft.AspNetCore.Identity;

namespace Mentora.Domin.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ProfileImage { get; set; }
        public ICollection<Course> OwnedCourses { get; set; } = new List<Course>();
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<QuizAttempt> Attempts { get; set; }
    = new List<QuizAttempt>();


    }
}
