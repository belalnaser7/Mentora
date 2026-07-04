using Mentora.Domain.Courses.Lessons.Question;
using Mentora.Domin.Common;
using Mentora.Domin.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.Domain.Courses.Lessons.Examination
{
    public enum QuizResultStatus
    {
        Failed = 0,
        Passed = 1
    }
    public class QuizAttempt : BaseEntity
    {
        public int QuizId { get; set; }

        public string UserId { get; set; } = string.Empty;

        public int Score { get; set; }

        public QuizResultStatus Status { get; set; }

        public int AttemptNumber { get; set; }

        public Quiz Quiz { get; set; } = default!;

        public ApplicationUser User { get; set; } = default!;
    }
}
