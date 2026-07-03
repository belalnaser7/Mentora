using Mentora.Domin.Identity;
using Mentora.Domin.Subscriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.InfraStructure.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
           
        }
    }
}
//builder.HasKey(p => p.Id);
//builder.Property(p => p.UserId).IsRequired();
//builder.HasOne<ApplicationUser>().WithOne().HasForeignKey<Cart>(P => P.UserId).OnDelete(DeleteBehavior.Cascade);