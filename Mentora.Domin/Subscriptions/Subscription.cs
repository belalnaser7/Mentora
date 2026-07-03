
using Mentora.Domin.Common;
using Mentora.Domin.Identity;
namespace Mentora.Domin.Subscriptions
{
    
    public class Subscription:BaseEntity
    {
        //public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int PackageId { get; set; }
        public bool IsAllowStrangerStudent { get; set; } = false;
        public int? Count { get; set; }
        public bool IsAutoRenew { get; set; } = false;
        public bool IsExpired { get; set; } = false;
        public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Pending;
        public ApplicationUser User { get; set; } = default!;
        public Package Package { get; set; } = default!;

    }
}
