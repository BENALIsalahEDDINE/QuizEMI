namespace QuizEMI.Web.ViewModels.Groups
{
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class GroupSimpleViewModel : IMapFrom<Group>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
