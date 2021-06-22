namespace QuizEMI.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using QuizEMI.Data.Models;

    public class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> studentGroup)
        {
            studentGroup.HasKey(pg => new { pg.StudentId, pg.GroupId });
        }
    }
}
