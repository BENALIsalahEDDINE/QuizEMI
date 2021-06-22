namespace QuizEMI.Web.ViewModels.Events
{
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class EventsAssignViewModel : IMapFrom<Event>
    {
        public string Id { get; set; }

        public string CreatorId { get; set; }

        public string Name { get; set; }

        public bool IsAssigned { get; set; }
    }
}
