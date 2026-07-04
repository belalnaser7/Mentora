using Mentora.Domin.Subscriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentora.InfraStructure.Presistence.Configurations.Subscriptions
{
    internal class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {

            // Primary Key
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Property(x => x.Price)
                .HasPrecision(8, 2);

            builder.Property(x => x.DurationInDays)
                .IsRequired();

            builder.Property(x => x.MaxCourses)
                .IsRequired();

            builder.Property(x => x.MaxStudents)
                .IsRequired();

            builder.Property(x => x.MaxStorageInGB)
                .IsRequired().HasMaxLength(200);


            // Relationships
            builder.HasMany(x => x.Subscriptions)
                .WithOne(x => x.Package)
                .HasForeignKey(x => x.PackageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
