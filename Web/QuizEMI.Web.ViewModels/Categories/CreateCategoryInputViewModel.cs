﻿namespace QuizEMI.Web.ViewModels.Categories
{
    using System.ComponentModel.DataAnnotations;

    using QuizEMI.Web.ViewModels.Shared;

    public class CreateCategoryInputViewModel
    {
        [Required]
        [StringLength(
            ModelValidations.Categories.NameMaxLength,
            ErrorMessage = ModelValidations.Error.RangeMessage,
            MinimumLength = ModelValidations.Categories.NameMinLength)]
        public string Name { get; set; }
    }
}
