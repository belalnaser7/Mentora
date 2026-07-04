using Mentora.Domain.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.InfraStructure.Presistence.Configurations.Courses
{
    public class CourseAccessCodeConfiguration : IEntityTypeConfiguration<CourseAccessCode>
    {
        public void Configure(EntityTypeBuilder<CourseAccessCode> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(6);
            builder.ToTable("CourseAccessCodes", table =>
            {
                table.HasCheckConstraint(
                    "CK_CourseAccessCode_Code",
                    "LEN(Code) = 6 AND Code NOT LIKE '%[^A-Z0-9]%'");
            });

            builder.HasIndex(x => x.Code)
                .IsUnique().IsUnique();

            builder.Property(x => x.IsUsed)
                .IsRequired();

            builder.Property(x => x.ExpireDate)
                .IsRequired(false);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
