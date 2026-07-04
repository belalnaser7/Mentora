using Mentora.Domain.Courses.Lessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentora.InfraStructure.Presistence.Configurations.Courses
{
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
           

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .HasMaxLength(3000);

            builder.Property(x => x.TotalMarks)
                .IsRequired();

            builder.Property(x => x.DueDate)
                .IsRequired(false);

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Homeworks)
                .HasForeignKey(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
