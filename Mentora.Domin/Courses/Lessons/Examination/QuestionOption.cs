using Mentora.Domin.Common;

namespace Mentora.Domain.Courses.Lessons.Question
{
    public class QuestionOption : BaseEntity
    {
        public string Text { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; } = default!;
    }
}

// حطه عشان اسالة ال MCQ ده بيدي زي فلاج للاختيار الصح  
