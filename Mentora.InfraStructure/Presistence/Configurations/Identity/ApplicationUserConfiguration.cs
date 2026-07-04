using Mentora.Domin.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentora.InfraStructure.Presistence.Configurations.Identity
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");

            // Properties

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.LastName)
               .IsRequired()
               .HasMaxLength(50);
            builder.Property(x => x.ProfileImage)
          .HasMaxLength(500);
        }
    }
}
