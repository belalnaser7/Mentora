using Mentora.Domin.Common;
using Mentora.Domin.Identity;

namespace Mentora.Domain.Courses
{
    public class CourseAccessCode:BaseEntity
    {
        public Guid Code { get; set; }
      //  public int CourseId { get; set; }
        public bool IsUsed { get; set; } = false;
        public string? UserId { get; set; }
        public DateTime? UsedAt { get; set; }
        public DateTime ExpireDate { get; set; }

       // public Course Course { get; set; } = default!;
       public Module module { get; set; } = default!;
        public ApplicationUser? User { get; set; }
    }
}

// انا وصلته عالطول بال user عشان اعرف مين الي استخدم الكود اول ما يعمل register بحيث مش كل شوية اروح اعملها عن طريق ال course واعمل projection او Eager 
//مش عارف هيكون في مشاكل في ال design datebase ولا ايه 
