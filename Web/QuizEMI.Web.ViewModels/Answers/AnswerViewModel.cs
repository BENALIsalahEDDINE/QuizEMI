﻿namespace QuizEMI.Web.ViewModels.Answers
{
    using System.ComponentModel.DataAnnotations;

    using Ganss.XSS;
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Shared;

    public class AnswerViewModel : IMapFrom<Answer>
    {
        public string Id { get; set; }

        [Required]
        [StringLength(
            ModelValidations.Answers.TextMaxLength,
            ErrorMessage = ModelValidations.Error.RangeMessage,
            MinimumLength = ModelValidations.Answers.TextMinLength)]
        public string Text { get; set; }

        public string SanitizedText => new HtmlSanitizer().Sanitize(this.Text);

        public bool IsRightAnswer { get; set; }

        public string QuestionId { get; set; }
    }
}
