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
    public class EnrollmentModuleConfiguration : IEntityTypeConfiguration<EnrollmentModule>
    {
        public void Configure(EntityTypeBuilder<EnrollmentModule> builder)
        {
            builder.ToTable("EnrollmentModules");

            builder.HasKey(x => new { x.EnrollmentId, x.ModuleId });

            builder.HasOne(x => x.Enrollment)
                .WithMany(x => x.EnrollmentModules)
                .HasForeignKey(x => x.EnrollmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Module)
                .WithMany(x => x.EnrollmentModules)
                .HasForeignKey(x => x.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
