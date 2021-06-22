namespace QuizEMI.Web.ViewModels.Groups
{
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class GroupAssignViewModel : IMapFrom<Group>
    {
        public string Id { get; set; }

        public string CreatorId { get; set; }

        public string Name { get; set; }

        public bool IsAssigned { get; set; }
    }
}
