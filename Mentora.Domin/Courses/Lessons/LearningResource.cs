using Mentora.Domin.Common;

namespace Mentora.Domain.Courses.Lessons
{
    public class LearningResource : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public ResourcesTypeEnum Type { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; } = default!;
    }
}
