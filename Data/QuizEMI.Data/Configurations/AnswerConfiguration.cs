namespace QuizEMI.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using QuizEMI.Data.Models;

    using QuizEMI.Data.Validations;

    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> answer)
        {
            answer.Property(a => a.Text)
                .HasMaxLength(DataValidation.Answer.TextMaxLength)
                .IsRequired();

            answer.Property(a => a.IsRightAnswer)
                .HasDefaultValue(false);
        }
    }
}
