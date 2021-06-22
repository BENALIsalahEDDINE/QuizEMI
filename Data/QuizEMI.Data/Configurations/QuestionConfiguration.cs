namespace QuizEMI.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using QuizEMI.Data.Models;

    using QuizEMI.Data.Validations;

    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> question)
        {
            question.HasMany(q => q.Answers)
                .WithOne(q => q.Question)
                .HasForeignKey(q => q.QuestionId);

            question.Property(q => q.Text)
                .HasMaxLength(DataValidation.Question.TextMaxLength)
                .IsRequired();
        }
    }
}
