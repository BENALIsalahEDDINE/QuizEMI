namespace QuizEMI.Web.ViewModels.Questions
{
    using System.ComponentModel.DataAnnotations;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Shared;

    public class QuestionInputModel : IMapFrom<Question>
    {
        public string Id { get; set; }

        [Required]
        [StringLength(
           ModelValidations.Question.TextMaxLength,
           ErrorMessage = ModelValidations.Error.RangeMessage,
           MinimumLength = ModelValidations.Question.TextMinLength)]
        public string Text { get; set; }
    }
}
