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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(300);

            builder.Property(x => x.ImageCourseUrl)
                .HasMaxLength(500).IsRequired();


            builder.HasIndex(x => x.Title).IsUnique();

            builder.HasOne(x => x.Owner)
                .WithMany(x => x.OwnedCourses)
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.level)
                .WithMany(x => x.Courses)
                .HasForeignKey(x => x.LevelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

