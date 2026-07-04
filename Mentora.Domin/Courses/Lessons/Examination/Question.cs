using Mentora.Domin.Common;

namespace Mentora.Domain.Courses.Lessons.Question
{
    public class Question : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public int Mark { get; set; }

        public QuestionTypeEnum Type { get; set; }
        public int Order { get; set; }

        public int QuizId { get; set; }


        public Quiz Quiz { get; set; } = default!;

        public ICollection<QuestionOption> Options { get; set; } = new List<QuestionOption>();
    }
}
