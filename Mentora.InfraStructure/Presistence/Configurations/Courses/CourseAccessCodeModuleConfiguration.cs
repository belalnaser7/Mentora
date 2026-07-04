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
    public class CourseAccessCodeModuleConfiguration : IEntityTypeConfiguration<CourseAccessCodeModule>
    {
        public void Configure(EntityTypeBuilder<CourseAccessCodeModule> builder)
        {
          

            builder.HasKey(x => new { x.CourseAccessCodeId, x.ModuleId });

            builder.HasOne(x => x.CourseAccessCode)
                .WithMany(x => x.CourseAccessCodeModules)
                .HasForeignKey(x => x.CourseAccessCodeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Module)
                .WithMany(x => x.CourseAccessCodeModules)
                .HasForeignKey(x => x.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
