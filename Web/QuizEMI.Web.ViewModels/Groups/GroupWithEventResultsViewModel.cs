namespace QuizEMI.Web.ViewModels.Groups
{
    using System.Collections.Generic;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Results;

    public class GroupWithEventResultsViewModel : IMapFrom<Group>
    {
        public GroupWithEventResultsViewModel()
        {
            this.Results = new HashSet<ResultViewModel>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ResultViewModel> Results { get; set; }
    }
}
