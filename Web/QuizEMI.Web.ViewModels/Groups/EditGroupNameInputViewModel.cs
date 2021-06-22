namespace QuizEMI.Web.ViewModels.Groups
{
    using System.ComponentModel.DataAnnotations;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Shared;

    public class EditGroupNameInputViewModel : IMapFrom<Group>
    {
        public string Id { get; set; }

        [Required]
        [StringLength(
            ModelValidations.Groups.NameMaxLength,
            ErrorMessage = ModelValidations.Error.RangeMessage,
            MinimumLength = ModelValidations.Groups.NameMinLength)]
        public string Name { get; set; }
    }
}
