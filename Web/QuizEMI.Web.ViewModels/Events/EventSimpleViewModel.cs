namespace QuizEMI.Web.ViewModels.Events
{
    using QuizEMI.Data.Common.Enumerations;
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class EventSimpleViewModel : IMapFrom<Event>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }
    }
}
