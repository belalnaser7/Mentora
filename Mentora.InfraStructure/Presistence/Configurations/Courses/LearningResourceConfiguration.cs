using Mentora.Domain.Courses.Lessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mentora.InfraStructure.Presistence.Configurations.Courses
{
    public class LearningResourceConfiguration : IEntityTypeConfiguration<LearningResource>
    {
        public void Configure(EntityTypeBuilder<LearningResource> builder)
        {
            builder.ToTable("LearningResources");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.Type)
                .IsRequired();

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.LearningResources)
                .HasForeignKey(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
