using Mentora.Domain.Courses;
using Mentora.Domain.Courses.Lessons.Question;
using Mentora.Domin.Common;

namespace Mentora.Domain.Courses.Lessons
{
    public class Lesson : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int Order { get; set; }

        public bool IsPublished { get; set; }

        // Foreign Key
        public int ModuleId { get; set; }

        // Navigation
        public Module Module { get; set; } = default!;

        public ICollection<LearningResource> LearningResources { get; set; } = new List<LearningResource>();

        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}