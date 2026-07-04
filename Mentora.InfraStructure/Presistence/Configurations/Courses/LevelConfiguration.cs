using Mentora.Domain.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Mentora.InfraStructure.Presistence.Configurations.Courses
{
    public class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Courselevel).IsRequired();
        }
    }
}
