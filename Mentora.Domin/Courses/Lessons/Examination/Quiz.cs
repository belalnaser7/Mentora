using Mentora.Domain.Courses.Lessons.Examination;
using Mentora.Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses.Lessons.Question
{
    public class Quiz : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int PassingScore { get; set; }

        public int TimeInMinutes { get; set; }
        public int TotalMarks { get; set; }
        public int MyProperty { get; set; }

        public bool IsPublished { get; set; } = false;

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; } = default!;
        public ICollection<QuizAttempt> Attempts { get; set; }
    = new List<QuizAttempt>();

        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
