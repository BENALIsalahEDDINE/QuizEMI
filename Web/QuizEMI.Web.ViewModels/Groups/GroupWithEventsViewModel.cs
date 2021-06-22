namespace QuizEMI.Web.ViewModels.Groups
{
    using System.Collections.Generic;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Events;

    public class GroupWithEventsViewModel : IMapFrom<Group>
    {
        public GroupWithEventsViewModel()
        {
            this.Events = new List<EventsAssignViewModel>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public bool Error { get; set; }

        public IList<EventsAssignViewModel> Events { get; set; }
    }
}
