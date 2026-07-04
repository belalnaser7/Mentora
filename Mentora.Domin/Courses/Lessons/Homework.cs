using Mentora.Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses.Lessons
{
    public class Homework : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; } //Deadline

        public int TotalMarks { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; } = default!;
    }
}
