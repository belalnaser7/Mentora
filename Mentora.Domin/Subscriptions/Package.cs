using Mentora.Domin.Common;

namespace Mentora.Domin.Subscriptions
{
    public class Package: BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int DurationInDays { get; set; }
        public int MaxCourses { get; set; }

        public int MaxStudents { get; set; }

        public int MaxVideos { get; set; }

        public int? MaxStorageInGB { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
      = new List<Subscription>();
    }
}
